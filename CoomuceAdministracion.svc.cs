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
    public interface ICoomuceAdministracion
    {
        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void GetOptions();

        [OperationContract]
        [WebGet(UriTemplate = "GetConfiguracionGeneralAll")]
        Stream GetAdminConfiguracionGeneralAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ConfiguracionGeneralU")]
        Stream AdminConfiguracionGeneralU(ConfiguracionGeneral datos);

        [OperationContract]
        [WebGet(UriTemplate = "GetConfiguracionCuerpoCorreoAll?tipo={tipo}")]
        Stream GetAdminConfiguracionCuerpoCorreoAll(byte tipo);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ConfiguracionCuerpoCorreoU")]
        Stream AdminConfiguracionCuerpoCorreoU(ConfiguracionCuerpoCorreo datos);

        [OperationContract]
        [WebGet(UriTemplate = "GetDepartamentoAll")]
        Stream GetAdminDepartamentoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DepartamentoCUD")]
        Stream AdminDepartamentoCUD(List<Departamento> nuevos, List<Departamento> viejos, List<Departamento> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetCiudadAll?idDepartamento={idDepartamento}")]
        Stream GetAdminCiudadAll(byte idDepartamento);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "CiudadCUD")]
        Stream AdminCiudadCUD(List<Ciudad> nuevos, List<Ciudad> viejos, List<Ciudad> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetRolAll")]
        Stream GetAdminRolAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetUsuarioAll")]
        Stream GetAdminUsuarioAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UsuarioCUD")]
        Stream AdminUsuarioCUD(List<Usuario> nuevos, List<Usuario> viejos, List<Usuario> eliminados);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UsuarioReenviarCredencial")]
        Stream AdminUsuarioReenviarCredencial(int idUsuario);

        [OperationContract]
        [WebGet(UriTemplate = "GetMenuAll")]
        Stream GetAdminMenuAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetPermisoRolAll?idRol={idRol}")]
        Stream GetAdminPermisosRolAll(byte idRol);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PermisosRolCUD")]
        Stream AdminPermisosRolCUD(List<RolMenu> nuevos, List<RolMenu> viejos, List<RolMenu> eliminados);
    }

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CoomuceAdministracion : ICoomuceAdministracion
    {
        Generales gen = new Generales();

        public void GetOptions()
        {
        }

        public Stream GetAdminConfiguracionGeneralAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.ConfiguracionGeneral.ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminConfiguracionGeneralU(ConfiguracionGeneral datos)
        {
            try
            {
                var db = new CoomuceEntities();

                var itemConf = db.ConfiguracionGeneral
                        .Where(r => r.idConfiguracionGeneral.Equals(datos.idConfiguracionGeneral))
                        .FirstOrDefault();

                itemConf.tiempoInactividadConfiguracionGeneral = datos.tiempoInactividadConfiguracionGeneral;
                itemConf.salarioConfiguracionGeneral = datos.salarioConfiguracionGeneral;
                itemConf.emailSalienteConfiguracionGeneral = datos.emailSalienteConfiguracionGeneral;
                itemConf.pswEmailConfiguracionGeneral = datos.pswEmailConfiguracionGeneral;
                itemConf.ccConfiguracionGeneral = datos.ccConfiguracionGeneral;
                itemConf.csConfiguracionGeneral = datos.csConfiguracionGeneral;
                itemConf.hostConfiguracionGeneral = datos.hostConfiguracionGeneral;
                itemConf.portConfiguracionGeneral = datos.portConfiguracionGeneral;
                itemConf.sslConfiguracionGeneral = datos.sslConfiguracionGeneral;

                db.SaveChanges();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminConfiguracionCuerpoCorreoAll(byte tipo)
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.ConfiguracionCuerpoCorreo.Where(r => r.tipoConfiguracionCuerpoCorreo == tipo).ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminConfiguracionCuerpoCorreoU(ConfiguracionCuerpoCorreo datos)
        {
            try
            {
                var db = new CoomuceEntities();

                var itemConf = db.ConfiguracionCuerpoCorreo
                        .Where(r => r.idConfiguracionCuerpoCorreo.Equals(datos.idConfiguracionCuerpoCorreo))
                        .FirstOrDefault();

                itemConf.tituloConfiguracionCuerpoCorreo = datos.tituloConfiguracionCuerpoCorreo;
                itemConf.mensajeConfiguracionCuerpoCorreo = datos.mensajeConfiguracionCuerpoCorreo;

                db.SaveChanges();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminDepartamentoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Departamento
                    .Select(r => new
                    {
                        r.idDepartamento,
                        r.codigoDepartamento,
                        r.nombreDepartamento
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminDepartamentoCUD(List<Departamento> nuevos, List<Departamento> viejos, List<Departamento> eliminados)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                // hay datos para eliminar?
                if (eliminados.Count > 0)
                {
                    eliminados.ForEach(e => db.Entry(e).State = EntityState.Deleted);

                    // eliminar registros
                    db.Departamento.RemoveRange(eliminados);
                }

                // hay datos para actualizar?
                if (viejos.Count > 0)
                {
                    viejos.ForEach(v => db.Entry(v).State = EntityState.Modified);
                }

                // hay datos para adicionar?
                if (nuevos.Count > 0)
                {
                    // agregar rango de nuevos registros
                    db.Departamento.AddRange(nuevos);
                }

                // guardo datos y confirmo transacción
                db.SaveChanges();
                transaction.Commit();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminCiudadAll(byte idDepartamento)
        {
            try
            {
                var db = new CoomuceEntities();

                var max = db.Ciudad.Max(r => r.idCiudad);

                var res = db.Ciudad
                    .Where(r => r.idDepartamento == idDepartamento)
                    .Select(r => new
                    {
                        r.idDepartamento,
                        r.idCiudad,
                        r.codigoCiudad,
                        r.nombreCiudad
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminCiudadCUD(List<Ciudad> nuevos, List<Ciudad> viejos, List<Ciudad> eliminados)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                // hay datos para eliminar?
                if (eliminados.Count > 0)
                {
                    eliminados.ForEach(e => db.Entry(e).State = EntityState.Deleted);

                    // eliminar registros
                    db.Ciudad.RemoveRange(eliminados);
                }

                // hay datos para actualizar?
                if (viejos.Count > 0)
                {
                    viejos.ForEach(v => db.Entry(v).State = EntityState.Modified);
                }

                // hay datos para adicionar?
                if (nuevos.Count > 0)
                {
                    // agregar rango de nuevos registros
                    db.Ciudad.AddRange(nuevos);
                }

                // guardo datos y confirmo transacción
                db.SaveChanges();
                transaction.Commit();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminRolAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Rol
                    .Select(r => new
                    {
                        r.idRol,
                        r.nombreRol
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminUsuarioAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Usuario
                    .Select(r => new
                    {
                        r.idUsuario,
                        r.idTipoIdentificacion,
                        r.TipoIdentificacion.nombreTipoIdentificacion,
                        r.identificacionUsuario,
                        r.primerApellidoUsuario,
                        r.segundoApellidoUsuario,
                        r.primerNombreUsuario,
                        r.segundoNombreUsuario,
                        r.emailUsuario,
                        r.celularUsuario,
                        r.idRol,
                        r.Rol.nombreRol,
                        r.esTemporalUsuario,
                        r.estaHabilitadoUsuario
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminUsuarioCUD(List<Usuario> nuevos, List<Usuario> viejos, List<Usuario> eliminados)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                // hay datos para eliminar?
                if (eliminados.Count > 0)
                {
                    // marcar registros para eliminar
                    eliminados.ForEach(e => db.Entry(e).State = EntityState.Deleted);

                    // eliminar registros
                    db.Usuario.RemoveRange(eliminados);
                }

                // hay datos para actualizar?
                if (viejos.Count > 0)
                {
                    // obtengo los id's de los items editados
                    var listaId = viejos.Select(v => v.idUsuario).ToList();

                    // obtengo los items editados
                    var itemEditar = db.Usuario.Where(r => listaId.Contains(r.idUsuario)).ToList();

                    // obtengo los datos editados
                    itemEditar.ForEach(r =>
                    {
                        var v = viejos.Where(i => i.idUsuario == r.idUsuario).FirstOrDefault();

                        r.idTipoIdentificacion = v.idTipoIdentificacion;
                        r.identificacionUsuario = v.identificacionUsuario;
                        r.primerApellidoUsuario = v.primerApellidoUsuario;
                        r.segundoApellidoUsuario = v.segundoApellidoUsuario;
                        r.primerNombreUsuario = v.primerNombreUsuario;
                        r.segundoNombreUsuario = v.segundoNombreUsuario;
                        r.emailUsuario = v.emailUsuario;
                        r.celularUsuario = v.celularUsuario;
                        r.idRol = v.idRol;
                        r.estaHabilitadoUsuario = v.estaHabilitadoUsuario;
                    });
                }

                // hay datos para adicionar?
                if (nuevos.Count > 0)
                {
                    foreach (var item in nuevos)
                    {
                        // obtener login de usuario
                        string loginUsuario = string.Format("{0}{1}{2}",
                            item.primerNombreUsuario.Substring(0, 1),
                            item.primerApellidoUsuario.Replace(" ", ""),
                            (string.IsNullOrEmpty(item.segundoApellidoUsuario) ? "" : item.segundoApellidoUsuario.Substring(0, 1)));

                        // verificar si hay un usuario con el mismo login
                        var existenLogin = db.Usuario
                            .Where(r => r.loginUsuario.Substring(0, loginUsuario.Length).Equals(loginUsuario))
                            .Count();

                        // se encontro usuarios con el mismo login?
                        if (existenLogin > 0)
                        {
                            existenLogin++;

                            loginUsuario += existenLogin.ToString();
                        }
                        item.loginUsuario = loginUsuario;

                        // se genera la contraseña
                        item.passwordUsuario = Membership.GeneratePassword(12, 0);
                        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                        byte[] data = new byte[5];
                        provider.GetBytes(data);
                        item.passwordSaltUsuario = Convert.ToBase64String(data);

                        item.passwordHashUsuario = FormsAuthentication.HashPasswordForStoringInConfigFile(item.passwordUsuario + item.passwordSaltUsuario, "SHA1");
                    }

                    // agregar rango de nuevos registros
                    db.Usuario.AddRange(nuevos);
                }

                // guardo datos y confirmo transacción
                db.SaveChanges();
                transaction.Commit();

                // hay nuevos datos?, si es asi enviamos los correos con las claves de acceso
                if (nuevos.Count > 0)
                {
                    foreach (var item in nuevos)
                    {
                        bool credencialesEnviadas = false;

                        credencialesEnviadas = gen.EnviarCorreo(item, 0);
                    }
                }

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminUsuarioReenviarCredencial(int idUsuario)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo datos de usuario
                var info = db.Usuario
                    .Where(r => r.idUsuario.Equals(idUsuario))
                    .FirstOrDefault();

                // enviar correo
                var credencialesEnviadas = gen.EnviarCorreo(info, 1);

                return gen.EscribirJson(new { message = (credencialesEnviadas ? Mensajes.CredencialesEnviadas : Mensajes.CredencialesNoEnviadas), success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminMenuAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Menu
                    .Select(r => new
                    {
                        r.idMenu,
                        r.nombreMenu
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetAdminPermisosRolAll(byte idRol)
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.RolMenu
                    .Where(r => r.idRol == idRol)
                    .Select(r => new
                    {
                        r.idRol,
                        r.Rol.nombreRol,
                        r.idMenu,
                        r.Menu.nombreMenu,
                        r.habilitadoRolMenu
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream AdminPermisosRolCUD(List<RolMenu> nuevos, List<RolMenu> viejos, List<RolMenu> eliminados)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                // hay datos para eliminar?
                if (eliminados.Count > 0)
                {
                    // marcar registros para eliminar
                    eliminados.ForEach(e => db.Entry(e).State = EntityState.Deleted);

                    // eliminar registros
                    db.RolMenu.RemoveRange(eliminados);
                }

                // hay datos para actualizar?
                if (viejos.Count > 0)
                {
                    viejos.ForEach(v => db.Entry(v).State = EntityState.Modified);
                }

                // hay datos para adicionar?
                if (nuevos.Count > 0)
                {
                    // agregar rango de nuevos registros
                    db.RolMenu.AddRange(nuevos);
                }

                // guardo datos y confirmo transacción
                db.SaveChanges();
                transaction.Commit();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }
    }
}
