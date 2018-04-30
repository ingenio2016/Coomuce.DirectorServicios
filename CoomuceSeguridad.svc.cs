using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Security;

using Coomuce.DirectorServicios.Clases;
using Coomuce.DirectorServicios.Entidad;
using Coomuce.DirectorServicios.Modelos;
using Coomuce.DirectorServicios.Recursos;

namespace Coomuce.DirectorServicios
{
    [ServiceContract]
    public interface ICoomuceSeguridad
    {
        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void GetOptions();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Autenticar")]
        Stream SeguridadAutenticar(string username, string password);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "CambiarContraseña")]
        Stream SeguridadCambiarContraseña(string username, string password, string newpassword);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "OlvidoContraseña")]
        Stream SeguridadOlvidoContraseña(string username);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "Reingresar")]
        Stream SeguridadReingresar(string username, string password);

        [OperationContract]
        [WebGet(UriTemplate = "GetMenu?idRol={idRol}")]
        Stream GetMainMenu(byte idRol);
    }

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CoomuceSeguridad : ICoomuceSeguridad
    {
        Generales gen = new Generales();

        public void GetOptions()
        {
        }

        public Stream SeguridadAutenticar(string username, string password)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo los datos del usuario
                var info = db.Usuario
                    .Where(r => r.loginUsuario.Equals(username) && r.passwordUsuario.Equals(password))
                    .FirstOrDefault();

                // verifico si existe el usuario
                if (info == null)
                {
                    return gen.EscribirJson(new { message = Mensajes.UsuarioIncorrecto, success = false });
                }

                // verifico si el usuario tiene clave temporal
                if (info.esTemporalUsuario)
                {
                    return gen.EscribirJson(new { message = Mensajes.UsuarioClaveTemporal, esTemporal = true, success = true });
                }

                // verifico si el usuario se encuentra activo
                if (!info.estaHabilitadoUsuario)
                {
                    return gen.EscribirJson(new { message = Mensajes.UsuarioInactivo, success = false });
                }

                // obtengo el tiempo de inactividad
                var cfg = db.ConfiguracionGeneral
                    .Select(r => new
                    {
                        r.tiempoInactividadConfiguracionGeneral,
                        r.salarioConfiguracionGeneral
                    })
                    .FirstOrDefault();

                var datos = new DatosSeguridad()
                {
                    idUsuario = info.idUsuario,
                    loginUsuario = info.loginUsuario,
                    nombreUsuario = string.Format("{0}{1}{2}{3}", 
                        info.primerApellidoUsuario, (string.IsNullOrEmpty(info.segundoApellidoUsuario) ? " ": " " + info.segundoApellidoUsuario + " "), 
                        info.primerNombreUsuario, (string.IsNullOrEmpty(info.segundoNombreUsuario) ? "" : " " + info.segundoNombreUsuario)),
                    nombreUsuarioFormato = string.Format("{0}{1}{2}{3}{4}",
                        info.primerApellidoUsuario, (string.IsNullOrEmpty(info.segundoApellidoUsuario) ? " " : " " + info.segundoApellidoUsuario), "<br />",
                        info.primerNombreUsuario, (string.IsNullOrEmpty(info.segundoNombreUsuario) ? "" : " " + info.segundoNombreUsuario)),
                    idRol = info.idRol,
                    nombreRol = info.Rol.nombreRol,
                    tiempoInactividad = cfg.tiempoInactividadConfiguracionGeneral,
                    salarioMinimo = cfg.salarioConfiguracionGeneral
                };

                return gen.EscribirJson(new { data = datos, message = Mensajes.UsuarioAutenticado, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream SeguridadCambiarContraseña(string username, string password, string newpassword)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo los datos del usuario
                var info = db.Usuario
                    .Where(r => r.loginUsuario.Equals(username) && r.passwordUsuario.Equals(password))
                    .FirstOrDefault();

                // verifico si existe el usuario
                if (info == null)
                {
                    return gen.EscribirJson(new { message = Mensajes.UsuarioIncorrecto, success = false });
                }

                info.passwordUsuario = newpassword;

                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                byte[] data = new byte[5];
                provider.GetBytes(data);
                info.passwordSaltUsuario = Convert.ToBase64String(data);

                info.passwordHashUsuario = FormsAuthentication.HashPasswordForStoringInConfigFile(info.passwordUsuario + info.passwordSaltUsuario, "SHA1");

                info.esTemporalUsuario = false;
                info.estaHabilitadoUsuario = true;

                db.SaveChanges();

                return gen.EscribirJson(new { message = Mensajes.UsuarioCambiarContraseña, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream SeguridadOlvidoContraseña(string username)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo los datos del usuario
                var info = db.Usuario
                    .Where(r => r.loginUsuario.Equals(username))
                    .FirstOrDefault();

                bool credencialesEnviadas = false;

                // verifico si existe el usuario
                if (info != null)
                {
                    credencialesEnviadas = gen.EnviarCorreo(info, 1);
                }

                return gen.EscribirJson(new
                {
                    message = (credencialesEnviadas ? Mensajes.CredencialesEnviadas : Mensajes.CredencialesNoEnviadas),
                    success = true
                });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream SeguridadReingresar(string username, string password)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo los datos del usuario
                var info = db.Usuario
                    .Where(r => r.loginUsuario.Equals(username))
                    .FirstOrDefault();

                if (!info.passwordUsuario.Equals(password))
                {
                    return gen.EscribirJson(new { message = Mensajes.UsuarioClaveIncorrecta, success = false });
                }

                return gen.EscribirJson(new { message = Mensajes.UsuarioReingresado, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetMainMenu(byte idRol)
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.RolMenu
                    .Where(r => r.idRol == idRol && r.habilitadoRolMenu == true)
                    .OrderBy(r => r.Menu.ordenMenu)
                    .Select(r => new obj
                    {
                        idMenu = r.Menu.idMenu,
                        idPadreMenu = r.Menu.idPadreMenu,
                        nomMenu = r.Menu.nombreMenu,
                        iconoMenu = r.Menu.iconoMenu,
                        idDomVista = r.Menu.Vista.idDomVista,
                        idVista = r.Menu.Vista.rutaVista
                    })
                    .ToList();

                var menu = ConstruirMenu.Contruir(null, res);

                return gen.EscribirJson(new { children = menu, message = Mensajes.MenuConstruido, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }
    }
}
