using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

using Newtonsoft.Json;

using Coomuce.DirectorServicios.Entidad;
using Coomuce.DirectorServicios.Recursos;

namespace Coomuce.DirectorServicios.Clases
{
    public class Generales
    {
        public Stream EscribirJson(string value)
        {
            // var jsSerializer = new JavaScriptSerializer();
            var json = Encoding.UTF8.GetBytes(value);
            var memStream = new MemoryStream(json);
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";

            return memStream;
        }

        public Stream EscribirJson(object value)
        {
            var js = new JavaScriptSerializer();
            js.MaxJsonLength = 2147483644;
            var jsonStr = js.Serialize(value);

            return EscribirJson(jsonStr);
        }


        public bool EnviarCorreo(Usuario datos, byte tipo)
        {
            try
            {
                var db = new CoomuceEntities();

                var cfg = db.ConfiguracionGeneral.FirstOrDefault();

                var ccc = db.ConfiguracionCuerpoCorreo.Where(r => r.tipoConfiguracionCuerpoCorreo == tipo).FirstOrDefault();

                MailMessage mail = new MailMessage();

                // correo destino
                mail.From = new MailAddress(cfg.emailSalienteConfiguracionGeneral);

                // correo origen
                mail.To.Add(datos.emailUsuario);

                // copia de correo
                mail.CC.Add(new MailAddress(cfg.ccConfiguracionGeneral));

                // asunto correo
                mail.Subject = ccc.tituloConfiguracionCuerpoCorreo;

                // contenido correo
                mail.Body = string.Format(ccc.mensajeConfiguracionCuerpoCorreo, 
                    datos.primerNombreUsuario, datos.segundoNombreUsuario, datos.primerApellidoUsuario, datos.segundoApellidoUsuario,
                    datos.loginUsuario, datos.passwordUsuario);

                // en formato html
                mail.IsBodyHtml = true;

                // prioridad de correo
                mail.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();

                // credenciales de autenticación
                smtp.Credentials = new NetworkCredential(cfg.emailSalienteConfiguracionGeneral, cfg.pswEmailConfiguracionGeneral);

                // host y puerto
                smtp.Host = cfg.hostConfiguracionGeneral;
                //smtp.Port = cfg.portConfiguracionGeneral;
                smtp.Port = 587;

                // ssl
                smtp.EnableSsl = true;

                smtp.Send(mail);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ObtenerRutaArchivos()
        {
            HttpServerUtility server = HttpContext.Current.Server;

            var path = server.MapPath("~/Files/");

            return path;
        }

        public HttpPostedFile ObtenerArchivo()
        {
            HttpRequest request = HttpContext.Current.Request;

            var file = request.Files[0];

            return file;
        }

        public void GenerarJSON(IEnumerable<dynamic> lista, string fileName)
        {
            var path = this.ObtenerRutaArchivos();

            StreamWriter jsonFile = File.CreateText(path + fileName + ".json");

            JsonSerializer serializer = new JsonSerializer();

            serializer.Serialize(jsonFile, new { data = lista, /*total = lista.Count,*/ success = true });

            jsonFile.Close();
        }
    }
}