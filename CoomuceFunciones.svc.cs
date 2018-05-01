using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Serialization;
using System.Web;
using System.Web.Script.Serialization;

using Coomuce.DirectorServicios.Clases;
using Coomuce.DirectorServicios.Entidad;
using Coomuce.DirectorServicios.Modelos;
using Coomuce.DirectorServicios.Recursos;
using Coomuce.DirectorServicios.ServiceReference;
using Coomuce.DirectorServicios.Historia;

namespace Coomuce.DirectorServicios
{
    [ServiceContract]
    public interface ICoomuceFunciones
    {
        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void GetOptions();

        #region Interfaces Actualización BD
        [OperationContract]
        [WebGet(UriTemplate = "GetTipoNovedadAll")]
        Stream GetFunTipoNovedadAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetDeclaracionAutorizacionAll")]
        Stream GetFunDeclaracionAutorizacionAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetFuanAfiliadoAll")]
        Stream GetFunFuanAfiliadoAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetFuanAfiliadoConsultar?campo={campo}&criterio={criterio}")]
        Stream GetFunFuanAfiliadoConsultarAll(string campo, string criterio);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AfiliacionGuardar")]
        Stream FunFuanAfiliacionGuardar(FuanModel infoFuan, List<AfiliadoModel> afiliado, List<FuanIpsPrimariaAfiliado> ips, List<FuanDeclaracionAutorizacion> declaracion, FuanEmpleadorAfiliado empleador);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "NovedadesGuardar")]
        Stream FunFuanNovedadesGuardar(int idFuanAfiliado, int idUsuario, List<FuanTipoNovedad> tipoNovedad, ReporteNovedadModel novedad);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarBase")]
        Stream FunFuanAfiliadosImportarBase();
        #endregion

        #region Interfaces Demanda Inducida
        [OperationContract]
        [WebGet(UriTemplate = "GetPurisuAll?start={start}&limit={limit}")]
        Stream GetFunPurisuAll(short start, byte limit);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PurisuGuardar")]
        Stream FunPurisuGuardar(InfoPurisuModel infoPurisu, List<PurisuModel> listaPurisuModel);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarAudioPurisu")]
        string FunPurisuImportarAudio();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PurisuGuardarCambios")]
        Stream FunPurisuGuardarCambios(List<InfoPurisuModel> datos);
        #endregion

        #region Interfaces Caracterización Poblacional
        
        [OperationContract]
        [WebGet(UriTemplate = "GetPreguntasFactorAll")]
        Stream GetFunPreguntasSubFactorRiesgoAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetPreguntasFactorPorCicloAll?edad={edad}&sexo={sexo}")]
        Stream GetFunPreguntasSubFactorRiesgoPorCicloAll(byte edad, byte sexo);

        [OperationContract]
        [WebGet(UriTemplate = "GetPreguntasCicloVitalGestanteAll")]
        Stream GetFunPreguntasCicloVitalGestanteAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetFunIfppirAll?start={start}&limit={limit}")]
        Stream GetFunIfppirPorDiligenciamientoAll(short start, byte limit);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "IfppirGuardar")]
        Stream FunIfppirGuardar(InfoIfppirModel infoIfppir, List<PreguntasFactorModel> listaIfppirModel);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "IfppirGuardarCambios")]
        Stream FunIfppirGuardarCambios(List<IfppirModel> datos);

        [OperationContract]
        [WebGet(UriTemplate = "GetNivelEducativoAll")]
        Stream GetFunNivelEducativoAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoAnimalAll")]
        Stream GetFunTipoAnimalAll();

        [OperationContract]
        [WebGet(UriTemplate = "GetFunHfdfrAll?start={start}&limit={limit}")]
        Stream GetFunHfdfrPorDiligenciamientoAll(short start, byte limit);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "HfdfrGuardar")]
        Stream FunHfdfrGuardar(InfoHfdfrModel info, HistoriaHfdfr historia);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "HfdfrGuardarCambios")]
        Stream FunHfdfrGuardarCambios(List<HfdfrModel> datos);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarAudioIfppir")]
        string FunCarPobImportarAudioIfppir();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarAudioHfdfr")]
        string FunCarPobImportarAudioHfdfr();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "IfppirConsultar")]
        Stream FunIfppirConsultar(string documento);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "HfdfrConsultar")]
        Stream FunHfdfrConsultar(string documento);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ConsultarWSFicha")]
        Stream FunConsultarWSFicha(String Usuario, String Contraseña, String Carnet);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ConsultarWSHistoria")]
        Stream FunConsultarWSHistoria(String Usuario, String Contraseña, String Carnet);
        #endregion

        #region Interfaces Información - Orientación
        [OperationContract]
        [WebGet(UriTemplate = "GetEncuestaAll?idDomVista={idDomVista}")]
        Stream GetFunEncuestaAll(string idDomVista);

        [OperationContract]
        [WebGet(UriTemplate = "GetIpsAll")]
        Stream GetFunIpsAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "EncuestaIpsGuardar")]
        Stream FunEncuestaIpsGuardar(EncuestaIpsModel encuestaIps, List<EncuestaIpsRespPregunta> respPregunta, List<EncuestaIpsRespLiteral> respLiteral);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "EncuestaEpsGuardar")]
        Stream FunEncuestaEpsGuardar(EncuestaEpsModel encuestaEps, List<EncuestaEpsRespPregunta> respPregunta, List<EncuestaEpsRespLiteral> respLiteral);
        #endregion

        #region Interfaces Participación Social
        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListaAsistenciaGeneralGuardar")]
        Stream FunParSocListaAsistenciaGeneralGuardar(AsistenciaGeneralModel infoAsistencia, List<ListaAsistenciaGeneral> listaAsistencia);

        [OperationContract]
        [WebGet(UriTemplate = "GetAsistenciaGeneralAll")]
        Stream GetFunParSocAsistenciaGeneralAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarFirma")]
        string FunParSocImportarFirma();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarDocumento")]
        string FunParSocImportarDocumento();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ImportarIncapacidadPermanente")]
        string FunParSocImportarIncapacidadPermanente();
        #endregion
    }

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CoomuceFunciones : ICoomuceFunciones
    {
        Generales gen = new Generales();

        public void GetOptions()
        {
        }

        #region Actualización BD
        public Stream GetFunTipoNovedadAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoNovedad
                    .Select(r => new FunTipoNovedadModel
                    {
                        idTipoNovedad = r.idTipoNovedad,
                        compTipoNovedad = r.codigoTipoNovedad + ". " + r.nombreTipoNovedad,
                        tipoValorCampoTipoNovedad =  r.tipoValorCampoTipoNovedad,
                        valorCampoTipoNovedad = r.valorCampoTipoNovedad
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunDeclaracionAutorizacionAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.DeclaracionAutorizacion
                    .Select(r => new FunDeclaracionAutorizacionModel
                    {
                        idDeclaracionAutorizacion = r.idDeclaracionAutorizacion,
                        compDeclaracionAutorizacion = r.codigoDeclaracionAutorizacion + ". " + r.descripcionDeclaracionAutorizacion
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunFuanAfiliadoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Usuario
                    .Where(r => r.estaHabilitadoUsuario)
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

                //var res = db.FuanAfiliado
                //    .Select(r => new /*FuanAfiliadoModel*/
                //    {
                //        r.idFuanAfiliado,
                //        r.primerApellidoFuanAfiliado,
                //        r.segundoApellidoFuanAfiliado,
                //        r.primerNombreFuanAfiliado,
                //        r.segundoNombreFuanAfiliado,
                //        //r.idTipoIdentificacion,
                //        r.TipoIdentificacion.codigoTipoIdentificacion,
                //        r.identificacionFuanAfiliado,
                //        r.fechaNacimientoFuanAfiliado,
                //        //edadFuanAfiliado = DateTime.Today.AddTicks(-r.fechaNacimientoFuanAfiliado.Ticks).Year - 1,
                //        //idDepartamento = r.Ciudad.idDepartamento,
                //        compDepartamento = "(" + r.Ciudad.Departamento.codigoDepartamento + ") " + r.Ciudad.Departamento.nombreDepartamento,
                //        //idCiudad = r.idCiudad,
                //        compCiudad = "(" + r.Ciudad.codigoCiudad + ") " + r.Ciudad.nombreCiudad,
                //        //puntajeSisbenFuanAfiliado = r.puntajeSisbenFuanAfiliado,
                //        //direccionFuanAfiliado = r.direccionFuanAfiliado,
                //        //telefonoFuanAfiliado = r.telefonoFuanAfiliado,
                //        //celularFuanAfiliado = r.celularFuanAfiliado,
                //        //emailFuanAfiliado = r.emailFuanAfiliado,
                //        //nombreTipoEtnia = r.TipoEtnia.nombreTipoEtnia,
                //        //nombreTipoZona = r.TipoZona.nombreTipoZona,
                //        r.idTipoSexo,
                //        r.TipoSexo.nombreTipoSexo,
                //        //pensionFuanAfiliado = r.pensionFuanAfiliado,
                //        r.numCarnetFuanAfiliado
                //    })
                //    .ToList();

                gen.GenerarJSON(res, "Usuario");

                return gen.EscribirJson(new { /*data = res, total = res.Count,*/ message = "archivo creado correctamente...", success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunFuanAfiliadoConsultarAll(string campo, string criterio)
        {
            try
            {
                var db = new CoomuceEntities();

                string sql = string.Format(@"
                    select a.idFuanAfiliado, a.primerApellidoFuanAfiliado, a.segundoApellidoFuanAfiliado, a.primerNombreFuanAfiliado,
                        a.segundoNombreFuanAfiliado, a.idTipoIdentificacion, b.codigoTipoIdentificacion, a.identificacionFuanAfiliado, a.fechaNacimientoFuanAfiliado,
                        c.idDepartamento, '(' + d.codigoDepartamento + ') ' + d.nombreDepartamento as compDepartamento,
                        c.idCiudad, '(' + c.codigoCiudad + ') ' + c.nombreCiudad as compCiudad,
                        a.puntajeSisbenFuanAfiliado, a.direccionFuanAfiliado, a.telefonoFuanAfiliado, a.celularFuanAfiliado,
                        a.emailFuanAfiliado, e.nombreTipoEtnia, f.nombreTipoZona, a.idTipoSexo, g.nombreTipoSexo, a.pensionFuanAfiliado, 
                        a.numCarnetFuanAfiliado, h.fechaUltFicha, h.fechaUltHistoria 
                    from FUN.FuanAfiliado as a 
	                    left join PAR.TipoIdentificacion as b on a.idTipoIdentificacion = b.idTipoIdentificacion 
	                    left join ADM.Ciudad as c on a.idCiudad = c.idCiudad 
	                    left join ADM.Departamento as d on c.idDepartamento = d.idDepartamento 
	                    left join PAR.TipoEtnia as e on a.idTipoEtnia = e.idTipoEtnia
	                    left join PAR.TipoZona as f on a.idTipoZona = f.idTipoZona
	                    left join PAR.TipoSexo as g on a.idTipoSexo = g.idTipoSexo 
                        left join FUN.HistorialUltimosFormatos as h on a.idFuanAfiliado = h.idFuanAfiliado
                    where (a.{0} like '%{1}%')", campo, criterio);

                var res = db.Database.SqlQuery<FuanAfiliadoModel>(sql).ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunFuanAfiliacionGuardar(FuanModel infoFuan, List<AfiliadoModel> afiliado, List<FuanIpsPrimariaAfiliado> ips, List<FuanDeclaracionAutorizacion> declaracion, FuanEmpleadorAfiliado empleador)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var idFuan = db.Fuan.Select(r => (int?)r.idFuan).Max();
                idFuan = (idFuan == null ? 1 : idFuan + 1);

                var fuan = new Fuan()
                {
                    idFuan = Convert.ToInt32(idFuan),
                    fechaRadicacionFuan = DateTime.Now,
                    idTipoTramite = infoFuan.idTipoTramite,
                    idTipoAfiliacion = infoFuan.idTipoAfiliacion,
                    idTipoRegimen = infoFuan.idTipoRegimen,
                    idTipoAfiliado = infoFuan.idTipoAfiliado,
                    idTipoCotizante = infoFuan.idTipoCotizante,
                    codigoCotizanteFuan = infoFuan.codigoCotizanteFuan,
                    idUsuario = infoFuan.idUsuario
                };

                var totalAfiliados = afiliado.Count;
                var idFuanAfiliado = db.FuanAfiliado.Max(r => (int?)r.idFuanAfiliado);
                idFuanAfiliado = (idFuanAfiliado == null ? 1 : idFuanAfiliado + 1);
                var idAfiliado = Convert.ToInt32(idFuanAfiliado);
                var infoAfiliado = new List<FuanAfiliado>();
                afiliado.ForEach(r =>
                {
                    infoAfiliado.Add(new FuanAfiliado()
                    {
                        idFuan = Convert.ToInt32(idFuan),
                        idFuanAfiliado = Convert.ToInt32(idFuanAfiliado),
                        tipoFuanAfiliado = r.tipoFuanAfiliado,
                        primerApellidoFuanAfiliado = r.primerApellidoFuanAfiliado,
                        segundoApellidoFuanAfiliado = r.segundoApellidoFuanAfiliado,
                        primerNombreFuanAfiliado = r.primerNombreFuanAfiliado,
                        segundoNombreFuanAfiliado = r.segundoNombreFuanAfiliado,
                        idTipoIdentificacion = r.idTipoIdentificacion,
                        identificacionFuanAfiliado = r.identificacionFuanAfiliado,
                        idTipoSexo = r.idTipoSexo,
                        fechaNacimientoFuanAfiliado = Convert.ToDateTime(r.fechaNacimientoFuanAfiliado),
                        idTipoEtnia = r.idTipoEtnia,
                        idTipoDiscapacidad = r.idTipoDiscapacidad,
                        idCondicionDiscapacidad = r.idCondicionDiscapacidad,
                        puntajeSisbenFuanAfiliado = r.puntajeSisbenFuanAfiliado,
                        numCarnetFuanAfiliado = r.numCarnetFuanAfiliado,
                        idGrupoPoblacional = r.idGrupoPoblacional,
                        arlFuanAfiliado = r.arlFuanAfiliado,
                        pensionFuanAfiliado = r.pensionFuanAfiliado,
                        ibcFuanAfiliado = r.ibcFuanAfiliado,
                        direccionFuanAfiliado = r.direccionFuanAfiliado,
                        telefonoFuanAfiliado = r.telefonoFuanAfiliado,
                        celularFuanAfiliado = r.celularFuanAfiliado,
                        emailFuanAfiliado = r.emailFuanAfiliado,
                        idCiudad = r.idCiudad,
                        idTipoZona = r.idTipoZona,
                        barrioFuanAfiliado = r.barrioFuanAfiliado,
                        primerApellidoConyugueFuanAfiliado = r.primerApellidoConyugueFuanAfiliado,
                        segundoApellidoConyugueFuanAfiliado = r.segundoApellidoConyugueFuanAfiliado,
                        primerNombreConyugueFuanAfiliado = r.primerNombreConyugueFuanAfiliado,
                        segundoNombreConyugueFuanAfiliado = r.segundoNombreConyugueFuanAfiliado,
                        idTipoIdentificacionConyugue = r.idTipoIdentificacionConyugue,
                        identificacionConyugueFuanAfiliado = r.identificacionConyugueFuanAfiliado,
                        idTipoSexoConyugue = r.idTipoSexoConyugue,
                        fechaNacimientoConyugueFuanAfiliado = (string.IsNullOrEmpty(r.fechaNacimientoConyugueFuanAfiliado) ? DateTime.Now: Convert.ToDateTime(r.fechaNacimientoConyugueFuanAfiliado)),
                        upcFuanAfiliado = r.upcFuanAfiliado
                    });

                    idFuanAfiliado += 1;
                });

                var idIps = db.FuanIpsPrimariaAfiliado.Max(r => (int?)r.idFuanIpsPrimariaAfiliado);
                idIps = (idIps == null ? 1 : idIps + 1);
                ips.ForEach(r =>
                {
                    r.idFuanIpsPrimariaAfiliado = Convert.ToInt32(idIps);
                    r.idFuanAfiliado = idAfiliado;

                    idIps += 1;
                });

                declaracion.ForEach(r =>
                {
                    r.idFuan = infoFuan.idFuan;
                });

                //var infoEntidadTerritorial = new FuanEntidadTerritorial()
                //{
                //    idFuan = infoFuan.idFuan,
                //    idCiudad = entidadTerritorial.idCiudad,
                //    numFichaSisbenFuanEntidadTerritorial = entidadTerritorial.numFichaSisbenFuanEntidadTerritorial,
                //    puntajeSisbenFuanEntidadTerritorial = entidadTerritorial.puntajeSisbenFuanEntidadTerritorial,
                //    nivelSisbenFuanEntidadTerritorial = entidadTerritorial.nivelSisbenFuanEntidadTerritorial,
                //    fechaRadicacionFuanEntidadTerritorial = Convert.ToDateTime(entidadTerritorial.fechaRadicacionFuanEntidadTerritorial),
                //    fechaValidacionFuanEntidadTerritorial = Convert.ToDateTime(entidadTerritorial.fechaValidacionFuanEntidadTerritorial),
                //    idUsuario = entidadTerritorial.idUsuario,
                //    observacionFuanEntidadTerritorial = entidadTerritorial.observacionFuanEntidadTerritorial
                //};

                var idEmpleador = db.FuanEmpleadorAfiliado.Max(r => (int?)r.idFuanEmpleadorAfiliado);
                idEmpleador = (idEmpleador == null ? 1 : idEmpleador + 1);
                empleador.idFuanEmpleadorAfiliado = Convert.ToInt32(idEmpleador);
                empleador.idFuanAfiliado = Convert.ToInt32(idAfiliado);

                db.Fuan.Add(fuan);
                db.FuanAfiliado.AddRange(infoAfiliado);
                db.FuanIpsPrimariaAfiliado.AddRange(ips);
                db.FuanDeclaracionAutorizacion.AddRange(declaracion);
                //db.FuanEntidadTerritorial.Add(infoEntidadTerritorial);
                db.FuanEmpleadorAfiliado.Add(empleador);

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

        public Stream FunFuanNovedadesGuardar(int idFuanAfiliado, int idUsuario, List<FuanTipoNovedad> tipoNovedad, ReporteNovedadModel novedad)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                // datos del afiliado a actualizar
                var afiliado = db.FuanAfiliado.Where(r => r.idFuanAfiliado == idFuanAfiliado).FirstOrDefault();

                // obtengo los datos del afiliado para el antes
                var antes = db.FuanAfiliado
                    .Where(r => r.idFuanAfiliado == idFuanAfiliado)
                    .Select(r => new ReporteNovedadModel
                    {
                        primerApellidoFuanAfiliado = r.primerApellidoFuanAfiliado,
                        segundoApellidoFuanAfiliado = r.segundoApellidoFuanAfiliado,
                        primerNombreFuanAfiliado = r.primerNombreFuanAfiliado,
                        segundoNombreFuanAfiliado = r.segundoNombreFuanAfiliado,
                        idTipoIdentificacion = r.idTipoIdentificacion,
                        compTipoIdentificacion = r.TipoIdentificacion.codigoTipoIdentificacion + " - " + r.TipoIdentificacion.nombreTipoIdentificacion,
                        identificacionFuanAfiliado = r.identificacionFuanAfiliado,
                        idTipoSexo = r.idTipoSexo,
                        compTipoSexo = r.TipoSexo.codigoTipoSexo + " - " + r.TipoSexo.nombreTipoSexo,
                        fechaNacimientoFuanAfiliado = r.fechaNacimientoFuanAfiliado.ToShortDateString(),
                        pensionFuanAfiliado = r.pensionFuanAfiliado,
                        idDepartamento = r.Ciudad.idDepartamento,
                        compDepartamento = r.Ciudad.Departamento.codigoDepartamento + " - " + r.Ciudad.Departamento.nombreDepartamento,
                        idCiudad = r.idCiudad,
                        compCiudad = r.Ciudad.codigoCiudad + " - " + r.Ciudad.nombreCiudad
                    })
                    .FirstOrDefault();

                XmlSerializer serializer = new XmlSerializer(typeof(ReporteNovedadModel));

                StringWriter xmlAntes = new StringWriter();
                serializer.Serialize(xmlAntes, antes);

                StringWriter xmlDespues = new StringWriter();
                serializer.Serialize(xmlDespues, novedad);

                var id = db.FuanReporteNovedad.Max(r => (int?)r.idFuanReporteNovedad);
                id = (int)(id == null ? 1 : id + 1);

                var infoReporte = new FuanReporteNovedad()
                {
                    idFuanReporteNovedad = (int)id,
                    fechaFuanReporteNovedad = DateTime.Now,
                    idFuanAfiliado = idFuanAfiliado,
                    antesFuanReporteNovedad = xmlAntes.ToString(),
                    despuesFuanReporteNovedad = xmlDespues.ToString(),
                    idUsuario = idUsuario
                };

                tipoNovedad.ForEach(r =>
                {
                    r.idFuanReporteNovedad = (int)id;
                });

                db.FuanReporteNovedad.Add(infoReporte);
                db.FuanTipoNovedad.AddRange(tipoNovedad);
                //ESTA PARTE YA NO DEBE IR
                afiliado.primerApellidoFuanAfiliado = novedad.primerApellidoFuanAfiliado;
                afiliado.segundoApellidoFuanAfiliado = novedad.segundoApellidoFuanAfiliado;
                afiliado.primerNombreFuanAfiliado = novedad.primerNombreFuanAfiliado;
                afiliado.segundoNombreFuanAfiliado = novedad.segundoNombreFuanAfiliado;
                afiliado.idTipoIdentificacion = novedad.idTipoIdentificacion;
                afiliado.identificacionFuanAfiliado = novedad.identificacionFuanAfiliado;
                afiliado.idTipoSexo = novedad.idTipoSexo;
                afiliado.fechaNacimientoFuanAfiliado = Convert.ToDateTime(novedad.fechaNacimientoFuanAfiliado);
                afiliado.idCiudad = (short)novedad.idCiudad;
                afiliado.firmaFuanAfiliado = novedad.firmaNovedad;

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

        public Stream FunFuanAfiliadosImportarBase()
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                db.Database.CommandTimeout = 1000;

                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);

                if (extension != ".xlsx")
                {
                    return gen.EscribirJson(new { message = "El archivo no es de extensión XLSX.", success = false });
                }

                var filename = "Base_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                OleDbConnectionStringBuilder cadenaConexion = new OleDbConnectionStringBuilder
                {
                    DataSource = path
                };
                cadenaConexion.Provider = "Microsoft.ACE.OLEDB.12.0";

                // verifico extensión para obtener cadena adecuada para la conexión
                cadenaConexion.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES;IMEX=0;");

                OleDbConnection conexion = new OleDbConnection(cadenaConexion.ConnectionString);
                //
                // abrir conexion con archivo
                conexion.Open();

                // obtener esquema de hojas
                DataTable oleDbSchemaTable = conexion.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                // obtener consulta
                OleDbCommand selectCommand = new OleDbCommand(
                    string.Format("SELECT * FROM [{0}]", Convert.ToString(oleDbSchemaTable.Rows[0]["TABLE_NAME"])), conexion)
                {
                    CommandType = CommandType.Text
                };

                OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand);

                DataTable datos = new DataTable();
                
                // obtener datos del data adapter
                adapter.Fill(datos);

                // cerrar conexion
                conexion.Close();

                var afiliados = new List<FuanAfiliado>();

                var idAfiliado = db.FuanAfiliado.Max(r => (int?)r.idFuanAfiliado);
                idAfiliado = (idAfiliado == null ? 1 : idAfiliado + 1);

                foreach (DataRow row in datos.Rows)
                {
                    var Carnet = Convert.ToString(row["Carnet"]);	
                    var primerApellidoFuanAfiliado = Convert.ToString(row["primerApellidoFuanAfiliado"]);
                    var segundoApellidoFuanAfiliado	= Convert.ToString(row["segundoApellidoFuanAfiliado"]); 
                    var primerNombreFuanAfiliado = Convert.ToString(row["primerNombreFuanAfiliado"]);
                    var segundoNombreFuanAfiliado = Convert.ToString(row["segundoNombreFuanAfiliado"]);
                    var idTipoIdentificacion = Convert.ToByte(row["idTipoIdentificacion"]);
                    var identificacionFuanAfiliado = Convert.ToString(row["identificacionFuanAfiliado"]);
                    var idTipoSexo = Convert.ToByte(row["idTipoSexo"]);
                    var fechaNacimientoFuanAfiliado = Convert.ToDateTime(row["fechaNacimientoFuanAfiliado"]);
                    var idTipoEtnia = Convert.ToByte(row["idTipoEtnia"]);
                    var idTipoDiscapacidad = Convert.IsDBNull(row["idTipoDiscapacidad"]) ? (byte?)null : Convert.ToByte(row["idTipoDiscapacidad"]);
                    var idCondicionDiscapacidad = Convert.IsDBNull(row["idCondicionDiscapacidad"]) ? (byte?)null : Convert.ToByte(row["idCondicionDiscapacidad"]);
                    var puntajeSisbenFuanAfiliado = Convert.IsDBNull(row["puntajeSisbenFuanAfiliado"]) ? (decimal?)null : Convert.ToDecimal(row["puntajeSisbenFuanAfiliado"]);
                    var idGrupoPoblacional = Convert.IsDBNull(row["idGrupoPoblacional"]) ? (byte?)null : Convert.ToByte(row["idGrupoPoblacional"]);
                    var arlFuanAfiliado = Convert.ToString(row["arlFuanAfiliado"]);
                    var pensionFuanAfiliado = Convert.ToString(row["pensionFuanAfiliado"]);
                    var ibcFuanAfiliado = Convert.IsDBNull(row["ibcFuanAfiliado"]) ? (decimal?)null : Convert.ToDecimal(row["ibcFuanAfiliado"]);
                    var direccionFuanAfiliado = Convert.ToString(row["direccionFuanAfiliado"]);
                    var telefonoFuanAfiliado = Convert.ToString(row["telefonoFuanAfiliado"]);
                    var celularFuanAfiliado = Convert.ToString(row["celularFuanAfiliado"]);
                    var emailFuanAfiliado = Convert.ToString(row["emailFuanAfiliado"]);
                    var CodDep = Convert.ToString(row["CodDep"]);
                    var CodMun = Convert.ToString(row["CodMun"]);
                    var idTipoZona = Convert.ToByte(row["idTipoZona"]);
                    var barrioFuanAfiliado = Convert.ToString(row["barrioFuanAfiliado"]);
                    var primerApellidoConyugueFuanAfiliado = Convert.ToString(row["primerApellidoConyugueFuanAfiliado"]);
                    var segundoApellidoConyugueFuanAfiliado = Convert.ToString(row["segundoApellidoConyugueFuanAfiliado"]);
                    var primerNombreConyugueFuanAfiliado = Convert.ToString(row["primerNombreConyugueFuanAfiliado"]);
                    var segundoNombreConyugueFuanAfiliado = Convert.ToString(row["segundoNombreConyugueFuanAfiliado"]);
                    var idTipoIdentificacionConyugue = Convert.IsDBNull(row["idTipoIdentificacionConyugue"]) ? (byte?)null : Convert.ToByte(row["idTipoIdentificacionConyugue"]);
                    var identificacionConyugueFuanAfiliado = Convert.ToString(row["identificacionConyugueFuanAfiliado"]);
                    var idTipoSexoConyugue = Convert.IsDBNull(row["idTipoSexoConyugue"]) ? (byte?)null : Convert.ToByte(row["idTipoSexoConyugue"]);
                    var fechaNacimientoConyugueFuanAfiliado = Convert.IsDBNull(row["fechaNacimientoConyugueFuanAfiliado"]) ? (DateTime?)null : Convert.ToDateTime(row["fechaNacimientoConyugueFuanAfiliado"]);
                    //var TipoIdCabezaFamilia	= row["TipoIdCabezaFamilia"];
                    //var NumidCabezaFamilia = row["NumidCabezaFamilia"];

                    var idCiudad = db.Ciudad.Where(r => r.codigoCiudad == CodMun && r.Departamento.codigoDepartamento == CodDep).Select(r => r.idCiudad).FirstOrDefault();

                    afiliados.Add(new FuanAfiliado
                    {
                        idFuanAfiliado = Convert.ToInt32(idAfiliado),
                        primerApellidoFuanAfiliado = primerApellidoFuanAfiliado,
                        segundoApellidoFuanAfiliado = segundoApellidoFuanAfiliado,
                        primerNombreFuanAfiliado = primerNombreFuanAfiliado,
                        segundoNombreFuanAfiliado = segundoNombreFuanAfiliado,
                        idTipoIdentificacion = idTipoIdentificacion,
                        identificacionFuanAfiliado = identificacionFuanAfiliado,
                        idTipoSexo = idTipoSexo,
                        fechaNacimientoFuanAfiliado = fechaNacimientoFuanAfiliado,
                        idTipoEtnia = idTipoEtnia,
                        idTipoDiscapacidad = idTipoDiscapacidad,
                        idCondicionDiscapacidad = idCondicionDiscapacidad,
                        puntajeSisbenFuanAfiliado = puntajeSisbenFuanAfiliado,
                        numCarnetFuanAfiliado = Carnet,
                        idGrupoPoblacional = idGrupoPoblacional,
                        arlFuanAfiliado = arlFuanAfiliado,
                        pensionFuanAfiliado = pensionFuanAfiliado,
                        ibcFuanAfiliado = ibcFuanAfiliado,
                        direccionFuanAfiliado = direccionFuanAfiliado,
                        telefonoFuanAfiliado = telefonoFuanAfiliado,
                        celularFuanAfiliado = celularFuanAfiliado,
                        emailFuanAfiliado = emailFuanAfiliado,
                        idCiudad = idCiudad,
                        idTipoZona = idTipoZona,
                        barrioFuanAfiliado = barrioFuanAfiliado,
                        primerApellidoConyugueFuanAfiliado = primerApellidoConyugueFuanAfiliado,
                        segundoApellidoConyugueFuanAfiliado = segundoApellidoConyugueFuanAfiliado,
                        primerNombreConyugueFuanAfiliado = primerNombreConyugueFuanAfiliado,
                        segundoNombreConyugueFuanAfiliado = segundoNombreConyugueFuanAfiliado,
                        idTipoIdentificacionConyugue = idTipoIdentificacionConyugue,
                        identificacionConyugueFuanAfiliado = identificacionConyugueFuanAfiliado,
                        idTipoSexoConyugue = idTipoSexoConyugue,
                        fechaNacimientoConyugueFuanAfiliado = fechaNacimientoConyugueFuanAfiliado
                    });

                    idAfiliado++;
                }

                var identificacion = afiliados.Select(a => a.identificacionFuanAfiliado).ToList();
                var itemsAfiliado = db.FuanAfiliado.Where(r => identificacion.Contains(r.identificacionFuanAfiliado)).ToList();
                itemsAfiliado.ForEach(r =>
                {
                    var item = afiliados.Where(a => a.identificacionFuanAfiliado == r.identificacionFuanAfiliado).FirstOrDefault();

                    item.idTipoEtnia = r.idTipoEtnia;
                    item.idTipoDiscapacidad = r.idTipoDiscapacidad;
                    item.idCondicionDiscapacidad = r.idCondicionDiscapacidad;
                    item.puntajeSisbenFuanAfiliado = r.puntajeSisbenFuanAfiliado;
                    item.numCarnetFuanAfiliado = r.numCarnetFuanAfiliado;
                    item.idGrupoPoblacional = r.idGrupoPoblacional;
                    item.arlFuanAfiliado = r.arlFuanAfiliado;
                    item.pensionFuanAfiliado = r.pensionFuanAfiliado;
                    item.ibcFuanAfiliado = r.ibcFuanAfiliado;
                    item.direccionFuanAfiliado = r.direccionFuanAfiliado;
                    item.telefonoFuanAfiliado = r.telefonoFuanAfiliado;
                    item.celularFuanAfiliado = r.celularFuanAfiliado;
                    item.emailFuanAfiliado = r.emailFuanAfiliado;
                    item.idCiudad = r.idCiudad;
                    item.idTipoZona = r.idTipoZona;
                    item.barrioFuanAfiliado = r.barrioFuanAfiliado;
                    item.primerApellidoConyugueFuanAfiliado = r.primerApellidoConyugueFuanAfiliado;
                    item.segundoApellidoConyugueFuanAfiliado = r.segundoApellidoConyugueFuanAfiliado;
                    item.primerNombreConyugueFuanAfiliado = r.primerNombreConyugueFuanAfiliado;
                    item.segundoNombreConyugueFuanAfiliado = r.segundoNombreConyugueFuanAfiliado;
                    item.idTipoIdentificacionConyugue = r.idTipoIdentificacionConyugue;
                    item.identificacionConyugueFuanAfiliado = r.identificacionConyugueFuanAfiliado;
                    item.idTipoSexoConyugue = r.idTipoSexoConyugue;
                    item.fechaNacimientoConyugueFuanAfiliado = r.fechaNacimientoConyugueFuanAfiliado;
                });

                var listA = itemsAfiliado.Select(i => i.identificacionFuanAfiliado).ToList();
                var filtroAfiliado = afiliados.Where(a => listA.Contains(a.identificacionFuanAfiliado)).ToList();

                db.FuanAfiliado.AddRange(filtroAfiliado);

                db.SaveChanges();
                transaction.Commit();

                return gen.EscribirJson(new { message = "Archivo procesado correctamente...", fileName = file.FileName, fileSize = file.ContentLength, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }
        #endregion

        #region Demanda Inducida
        public Stream GetFunPurisuAll(short start, byte limit)
        { 
            try
            {
                var db = new CoomuceEntities();

                var res = db.InfoPurisu
                    .Where(r => r.tipoDiligenciamientoInfoPurisu == "Telefonico")
                    .Select(r => new
                    {
                        r.idInfoPurisu,
                        r.idCiudad,
                        r.fechaAtencionPurisu,
                        r.idUsuario,
                        nombreCompletoUsuario = r.Usuario.primerApellidoUsuario + " " + r.Usuario.segundoApellidoUsuario + " " +
                            r.Usuario.primerNombreUsuario + " " + r.Usuario.segundoNombreUsuario,
                        r.archivoAudioInfoPurisu,
                        r.tipoDiligenciamientoInfoPurisu
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res.Skip(start).Take(limit).ToList(), total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunPurisuGuardar(InfoPurisuModel infoPurisu, List<PurisuModel> listaPurisuModel)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var idInfoPurisu = db.InfoPurisu.Select(r => (int?)r.idInfoPurisu).Max();
                idInfoPurisu = (idInfoPurisu == null ? 1 : idInfoPurisu + 1);

                var info = new InfoPurisu() 
                {
                    idInfoPurisu = Convert.ToInt32(idInfoPurisu),
                    idCiudad = infoPurisu.idCiudad,
                    idUsuario = infoPurisu.idUsuario,
                    fechaAtencionPurisu = Convert.ToDateTime(infoPurisu.fechaAtencionPurisu),
                    tipoDiligenciamientoInfoPurisu = "Personal"
                };

                var listaPurisu = new List<Purisu>();
                foreach (var item in listaPurisuModel)
                {
                    var purisu = new Purisu()
                    {
                        idInfoPurisu = Convert.ToInt32(idInfoPurisu),
                        idPurisu = item.idPurisu,
                        numCarnePurisu = item.numCarnePurisu,
                        idFuanAfiliado = item.idFuanAfiliado,
                        idTipoVisitaDomiciliaria = item.idTipoVisitaDomiciliaria,
                        usisPurisu = item.usisPurisu,
                        ipsPrimariaPurisu = item.ipsPrimariaPurisu,
                        telefonicaPurisu = item.telefonicaPurisu,
                        cauPurisu = item.cauPurisu,
                        actividadExtramuralPurisu = item.actividadExtramuralPurisu,
                        idProgramaResolucion412 = item.idProgramaResolucion412,
                        idGrupoInteres = item.idGrupoInteres,
                        idSeguimientoProgramasIntervencionRiesgo = item.idSeguimientoProgramasIntervencionRiesgo,
                        numAutorizacionPurisu = item.numAutorizacionPurisu,
                        idGruposFocales = item.idGruposFocales,
                        idEje = item.idEje,
                        idUnidad = item.idUnidad,
                        idModulo = item.idModulo,
                        idEje1 = item.idEje1,
                        idUnidad1 = item.idUnidad1,
                        idModulo1 = item.idModulo1,
                        firmaPurisu = item.firmaPurisu
                    };

                    item.idMotivoConsulta.ForEach(r => 
                    {
                        var dato = db.MotivoConsulta.Where(d => d.idMotivoConsulta == r).FirstOrDefault();
                        purisu.MotivoConsulta.Add(dato);
                    });

                    item.idMotivoContacto.ForEach(r =>
                    {
                        var dato = db.MotivoContacto.Where(d => d.idMotivoContacto == r).FirstOrDefault();
                        purisu.MotivoContacto.Add(dato);
                    });

                    item.idPiezasInformativas.ForEach(r =>
                    {
                        var dato = db.PiezasInformativas.Where(d => d.idPiezasInformativas == r).FirstOrDefault();
                        purisu.PiezasInformativas.Add(dato);
                    });

                    listaPurisu.Add(purisu);
                }

                db.InfoPurisu.Add(info);
                db.Purisu.AddRange(listaPurisu);

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

        public string FunPurisuImportarAudio()
        {
            try
            {
                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);
                var filename = "AudioPurisu_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                return filename;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Stream FunPurisuGuardarCambios(List<InfoPurisuModel> datos)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var listaId = datos.Select(d => d.idInfoPurisu).ToList();

                var items = db.InfoPurisu.Where(r => listaId.Contains(r.idInfoPurisu)).ToList();

                items.ForEach(r =>
                {
                    var it = datos.Where(d => d.idInfoPurisu == r.idInfoPurisu).FirstOrDefault();

                    r.archivoAudioInfoPurisu = it.archivoAudioInfoPurisu;
                });

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
        #endregion

        #region Caracterización Poblacional
        public Stream GetFunPreguntasSubFactorRiesgoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.PreguntasSubFactorRiesgo
                    .OrderBy(r => new { r.SubFactorRiesgo.FactorRiesgo.idFactorRiesgo, r.SubFactorRiesgo.idSubFactorRiesgo, r.idPreguntasSubFactorRiesgo })
                    .Select(r => new PreguntasFactorModel
                    {
                        idPregunta = r.idPreguntasSubFactorRiesgo,
                        factor = r.SubFactorRiesgo.FactorRiesgo.codigoFactorRiesgo + " " + r.SubFactorRiesgo.FactorRiesgo.nombreFactorRiesgo,
                        subfactor = r.SubFactorRiesgo.codigoSubFactorRiesgo + " " + r.SubFactorRiesgo.nombreSubFactorRiesgo,
                        codigoPregunta = r.codigoPreguntasSubFactorRiesgo,
                        descripcionPregunta = r.descripcionPreguntasSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunPreguntasSubFactorRiesgoPorCicloAll(byte edad, byte sexo)
        {
            try
            {
                var db = new CoomuceEntities();

                var idCiclo = db.CicloVital.Where(r => edad >= r.edadMinCicloVital && edad <= r.edadMaxCicloVital).Select(r => r.idCicloVital).FirstOrDefault();

                var res = db.CicloVitalPreguntasSubFactorRiesgo
                    .Where(r => r.idCicloVital == idCiclo && r.idTipoSexo == sexo)
                    .Select(r => new PreguntasFactorModel
                    {
                        idPregunta = r.idPreguntasSubFactorRiesgo,
                        factor = r.PreguntasSubFactorRiesgo.SubFactorRiesgo.FactorRiesgo.codigoFactorRiesgo + " " + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.FactorRiesgo.nombreFactorRiesgo,
                        subfactor = r.PreguntasSubFactorRiesgo.SubFactorRiesgo.codigoSubFactorRiesgo + " " + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.nombreSubFactorRiesgo,
                        codigoPregunta = r.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                        descripcionPregunta = r.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunPreguntasCicloVitalGestanteAll() 
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.CicloVitalGestante
                    .Select(r => new PreguntasFactorModel
                    {
                        idPregunta = r.idPreguntasSubFactorRiesgo,
                        factor = r.PreguntasSubFactorRiesgo.SubFactorRiesgo.FactorRiesgo.codigoFactorRiesgo + " " + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.FactorRiesgo.nombreFactorRiesgo,
                        subfactor = r.PreguntasSubFactorRiesgo.SubFactorRiesgo.codigoSubFactorRiesgo + " " + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.nombreSubFactorRiesgo,
                        codigoPregunta = r.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo,
                        descripcionPregunta = r.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }
        
        public Stream GetFunIfppirPorDiligenciamientoAll(short start, byte limit)
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.InfoIfppir
                    .Where(r => r.tipoDiligenciamientoIfppir == "Telefonico")
                    .Select(r => new
                    {
                        r.idInfoIfppir,
                        r.tipoDiligenciamientoIfppir,
                        r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                        r.FuanAfiliado.identificacionFuanAfiliado,
                        compAfiliado = r.FuanAfiliado.primerApellidoFuanAfiliado + " " + r.FuanAfiliado.segundoApellidoFuanAfiliado + " " +
                            r.FuanAfiliado.primerNombreFuanAfiliado + " " + r.FuanAfiliado.segundoNombreFuanAfiliado,
                        r.archivoAudioIfppir
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res.Skip(start).Take(limit).ToList(), total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunIfppirGuardar(InfoIfppirModel infoIfppir, List<PreguntasFactorModel> listaIfppirModel)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var idInfoIfppir = db.InfoIfppir.Select(r => (int?)r.idInfoIfppir).Max();
                idInfoIfppir = (idInfoIfppir == null ? 1 : idInfoIfppir + 1);
                DateTime datetimeNull = DateTime.Now;
                DateTime? fechas = null;
                var ifppir = new InfoIfppir()
                {
                    idInfoIfppir = Convert.ToInt32(idInfoIfppir),
                    fechaInfoIfppir = DateTime.Now,
                    tipoDiligenciamientoIfppir = infoIfppir.tipoDiligenciamientoIfppir,
                    idFuanAfiliado = infoIfppir.idFuanAfiliado,
                    numCarneIfppir = infoIfppir.numCarneIfppir,
                    ipsPrimariaIfppir = infoIfppir.ipsPrimariaIfppir,
                    razaIfppir = infoIfppir.razaIfppir,
                    escolaridadIfppir = infoIfppir.escolaridadIfppir,
                    familiarCercanoIfppir = infoIfppir.familiarCercanoIfppir,
                    telefonoFamiliarIfppir = infoIfppir.telefonoFamiliarIfppir,
                    gestanteIfppir = infoIfppir.gestanteIfppir,
                    fechaAplicacionIfppir = (infoIfppir.fechaAplicacionIfppir == "") ? DateTime.Now : Convert.ToDateTime(infoIfppir.fechaAplicacionIfppir).AddMonths(1),
                    furIfppir = (infoIfppir.furIfppir == "" || infoIfppir.furIfppir == null) ? fechas : Convert.ToDateTime(infoIfppir.furIfppir),
                    fppIfppir = (infoIfppir.fppIfppir == "" || infoIfppir.fppIfppir == null) ? fechas : Convert.ToDateTime(infoIfppir.fppIfppir),
                    pesoIfppir = infoIfppir.pesoIfppir,
                    tallaIfppir = infoIfppir.tallaIfppir,
                    masaCorporalIfppir = infoIfppir.masaCorporalIfppir,
                    perimetroAbdominalIfppir = infoIfppir.perimetroAbdominalIfppir,
                    sistolicaIfppir = infoIfppir.sistolicaIfppir,
                    diastolicaIfppir = infoIfppir.diastolicaIfppir,
                    colesterolTotalIfppir = infoIfppir.colesterolTotalIfppir,
                    colesterolLdlIfppir = infoIfppir.colesterolLdlIfppir,
                    colesterolHdlIfppir = infoIfppir.colesterolHdlIfppir,
                    glicemiaIfppir = infoIfppir.glicemiaIfppir,
                    gIfppir = infoIfppir.gIfppir,
                    pIfppir = infoIfppir.pIfppir,
                    cIfppir = infoIfppir.cIfppir,
                    aIfppir = infoIfppir.aIfppir,
                    nacidoVivoIfppir = infoIfppir.nacidoVivoIfppir,
                    observacionIfppir = infoIfppir.observacionIfppir,
                    firmaIfppir = infoIfppir.firmaIfppir,
                    idUsuario = infoIfppir.idUsuario
                };
                

                var listaRespuestas = new List<IfppirRespuestaFactor>();

                foreach (var item in listaIfppirModel)
                {
                    var respuesta = new IfppirRespuestaFactor();

                    respuesta.idInfoIfppir = Convert.ToInt32(idInfoIfppir);
                    respuesta.idPreguntasSubFactorRiesgo = item.idPregunta;
                    respuesta.respuestaSiIfppirRespuestaFactor = item.respuestaSiPregunta;
                    respuesta.respuestaNoIfppirRespuestaFactor = item.respuestaNoPregunta;

                    listaRespuestas.Add(respuesta);
                }

                var huf = db.HistorialUltimosFormatos.Where(r => r.idFuanAfiliado == ifppir.idFuanAfiliado).FirstOrDefault();

                if (huf == null)
                {
                    huf = new HistorialUltimosFormatos()
                    {
                        idFuanAfiliado = ifppir.idFuanAfiliado,
                        fechaUltFicha = (string.IsNullOrEmpty(infoIfppir.fechaAplicacionIfppir)) ? DateTime.Now : Convert.ToDateTime(infoIfppir.fechaAplicacionIfppir)
                    };

                    db.HistorialUltimosFormatos.Add(huf);
                }
                else
                {
                    huf.fechaUltFicha = (string.IsNullOrEmpty(infoIfppir.fechaAplicacionIfppir)) ? DateTime.Now : Convert.ToDateTime(infoIfppir.fechaAplicacionIfppir);
                }

                db.InfoIfppir.Add(ifppir);
                db.IfppirRespuestaFactor.AddRange(listaRespuestas);

                db.SaveChanges();
                transaction.Commit();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return gen.EscribirJson(new { data = ex.InnerException.InnerException, message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunIfppirGuardarCambios(List<IfppirModel> datos)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var listaId = datos.Select(d => d.idInfoIfppir).ToList();

                var items = db.InfoIfppir.Where(r => listaId.Contains(r.idInfoIfppir)).ToList();

                items.ForEach(r =>
                {
                    var it = datos.Where(d => d.idInfoIfppir == r.idInfoIfppir).FirstOrDefault();

                    r.archivoAudioIfppir = it.archivoAudioIfppir;
                });

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

        public Stream GetFunNivelEducativoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.NivelEducativo
                    .Select(r => new NivelEducativoModel
                    {
                        idNivelEducativo = r.idNivelEducativo,
                        compNivelEducativo = r.codigoNivelEducativo + " - " + r.nombreNivelEducativo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunTipoAnimalAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoAnimal
                    .Select(r => new TipoAnimalModel
                    {
                        idTipoAnimal = r.idTipoAnimal,
                        compTipoAnimal = r.codigoTipoAnimal + " - " + r.nombreTipoAnimal
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunHfdfrPorDiligenciamientoAll(short start, byte limit)
        { 
            try
            {
                var db = new CoomuceEntities();

                var res = db.InfoHfdfr
                    .Where(r => r.tipoDiligenciamientoHfdfr == "Telefonico")
                    .Select(r => new
                    {
                        r.idInfoHfdfr,
                        r.tipoDiligenciamientoHfdfr,
                        r.fechaVisitaHfdfr,
                        r.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                        r.FuanAfiliado.identificacionFuanAfiliado,
                        compAfiliado = r.FuanAfiliado.primerApellidoFuanAfiliado + " " + r.FuanAfiliado.segundoApellidoFuanAfiliado + " " + 
                            r.FuanAfiliado.primerNombreFuanAfiliado + " " + r.FuanAfiliado.segundoNombreFuanAfiliado,
                        r.archivoAudioHfdfr
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res.Skip(start).Take(limit).ToList(), total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunHfdfrGuardar(InfoHfdfrModel info, HistoriaHfdfr historia)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(HistoriaHfdfr));

                StringWriter xml = new StringWriter();
                serializer.Serialize(xml, historia);

                var infoHfdfr = new InfoHfdfr();

                var id = db.InfoHfdfr.Max(r => (int?)r.idInfoHfdfr);
                id = (int)(id == null ? 1 : id + 1);
                infoHfdfr.idInfoHfdfr = (int)id;
                infoHfdfr.tipoDiligenciamientoHfdfr = "Personal";
                infoHfdfr.fechaVisitaHfdfr = Convert.ToDateTime(info.fechaVisitaHfdfr).AddMonths(1);
                infoHfdfr.fechaInfoHfdfr = DateTime.Now;
                infoHfdfr.horaInicioHfdfr = info.horaInicioHfdfr;
                infoHfdfr.horaFinHfdfr = info.horaFinHfdfr;
                infoHfdfr.idFuanAfiliado = info.idFuanAfiliado;
                infoHfdfr.idCiudad = info.idCiudad;
                infoHfdfr.veredaInfoHfdfr = info.veredaInfoHfdfr;
                infoHfdfr.barrioInfoHfdfr = info.barrioInfoHfdfr;
                infoHfdfr.telefonoInfoHfdfr = info.telefonoInfoHfdfr;
                infoHfdfr.historiaInfoHfdfr = xml.ToString();
                infoHfdfr.firmaHfdfr = info.firmaHfdfr;
                infoHfdfr.idUsuario = info.idUsuario;

                var huf = db.HistorialUltimosFormatos.Where(r => r.idFuanAfiliado == infoHfdfr.idFuanAfiliado).FirstOrDefault();

                if (huf == null)
                {
                    huf = new HistorialUltimosFormatos()
                    {
                        idFuanAfiliado = infoHfdfr.idFuanAfiliado,
                        fechaUltHistoria = Convert.ToDateTime(info.fechaVisitaHfdfr)
                    };
                    db.HistorialUltimosFormatos.Add(huf);
                }
                else
                {
                    huf.fechaUltHistoria = Convert.ToDateTime(info.fechaVisitaHfdfr);
                }

                db.InfoHfdfr.Add(infoHfdfr);

                db.SaveChanges();
                transaction.Commit();

                xml.Close();

                return gen.EscribirJson(new { message = Mensajes.Guardar, success = true });
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return gen.EscribirJson(new { data = ex.InnerException.InnerException, message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunHfdfrGuardarCambios(List<HfdfrModel> datos)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var listaId = datos.Select(d => d.idInfoHfdfr).ToList();

                var items = db.InfoHfdfr.Where(r => listaId.Contains(r.idInfoHfdfr)).ToList();

                items.ForEach(r =>
                {
                    var it = datos.Where(d => d.idInfoHfdfr == r.idInfoHfdfr).FirstOrDefault();

                    r.archivoAudioHfdfr = it.archivoAudioHfdfr;
                });

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

        public string FunCarPobImportarAudioIfppir()
        {
            try
            {
                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);
                var filename = "AudioIfppir_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                return filename;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string FunCarPobImportarAudioHfdfr()
        {
            try
            {
                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);
                var filename = "AudioHfdfr_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                return filename;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Stream FunIfppirConsultar(string documento)
        {
            try
            {
                var db = new CoomuceEntities();

                var afiliado = db.FuanAfiliado.Where(a => a.identificacionFuanAfiliado == documento).FirstOrDefault();
                if(afiliado != null)
                {
                    var fichas = db.InfoIfppir.Where(f => f.idFuanAfiliado == afiliado.idFuanAfiliado)
                        .Select(r => new
                        {
                            idInfoIfppir = r.idInfoIfppir,
                            fechaAplicacionIfppir = r.fechaAplicacionIfppir
                        }).OrderBy(r=>r.fechaAplicacionIfppir).ToList();

                    List<fichaModel> listafichas = new List<fichaModel>();
                    foreach(var item in fichas)
                    {
                        var newFicha = new fichaModel {
                            idInfoIfppir = Convert.ToInt32(item.idInfoIfppir),
                            fechaAplicacionIfppir = item.fechaAplicacionIfppir.ToShortDateString()
                        };

                        listafichas.Add(newFicha);
                    }

                    return gen.EscribirJson(new { data = listafichas, total = fichas.Count, message = "Se han encontrado un total de " + fichas.Count + " fichas", success = true });
                }else
                {
                    return gen.EscribirJson(new { message = "No se Encontraron Fichas", success = false });
                }
                
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunHfdfrConsultar(string documento)
        {
            try
            {
                var db = new CoomuceEntities();

                var afiliado = db.FuanAfiliado.Where(a => a.identificacionFuanAfiliado == documento).FirstOrDefault();
                if (afiliado != null)
                {
                    var historias = db.InfoHfdfr.Where(f => f.idFuanAfiliado == afiliado.idFuanAfiliado)
                        .Select(r => new
                        {
                            idInfoHfdfr = r.idInfoHfdfr,
                            fechaVisitaHfdfr = r.fechaVisitaHfdfr
                        }).OrderBy(r => r.fechaVisitaHfdfr).ToList();

                    List<historiaModel> listahistorias = new List<historiaModel>();
                    foreach (var item in historias)
                    {
                        var newHistoria = new historiaModel
                        {
                            idInfoHfdfr = Convert.ToInt32(item.idInfoHfdfr),
                            fechaVisitaHfdfr = item.fechaVisitaHfdfr.ToShortDateString()
                        };

                        listahistorias.Add(newHistoria);
                    }

                    return gen.EscribirJson(new { data = listahistorias, total = listahistorias.Count, message = "Se han encontrado un total de " + listahistorias.Count + " historias", success = true });
                }
                else
                {
                    return gen.EscribirJson(new { message = "No se Encontraron Historias", success = false });
                }

            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunConsultarWSFicha(String Usuario, String Contraseña, String Carnet)
        {
            try
            {
                IList<VerificaFicha_042EL> Resultados = new List<VerificaFicha_042EL>();
                VerificaFicha_042EL Resultado = new VerificaFicha_042EL();
                if (Carnet != "")
                {
                    Ficha_042Client Cliente = new Ficha_042Client();
                    Cliente.InnerChannel.OperationTimeout = new TimeSpan(0, 20, 0);
                    Resultado = Cliente.VerificaFicha042(Usuario, Contraseña, Carnet);
                    Resultados = new List<VerificaFicha_042EL>();
                    Resultados.Add(Resultado);
                    Cliente.Close();
                }
                else
                {
                    Resultado.Carnet = "";
                    Resultado.AfiliadoActivo = false;
                    Resultado.ExisteAfiliado = false;
                    Resultado.ExisteFicha = false;
                    Resultado.Mensaje = "Por favor Digitar un Carnet";
                    Resultados.Add(Resultado);
                }
                return gen.EscribirJson(new { data = Resultados, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunConsultarWSHistoria(String Usuario, String Contraseña, String Carnet)
        {
            try
            {
                IList<VerificaFicha_028EL> Resultados = new List<VerificaFicha_028EL>();
                VerificaFicha_028EL Resultado = new VerificaFicha_028EL();
                if (Carnet != "")
                {
                    Ficha_028Client Cliente = new Ficha_028Client();
                    Cliente.InnerChannel.OperationTimeout = new TimeSpan(0, 20, 0);
                    Resultado = Cliente.VerificaFicha028(Usuario, Contraseña, Carnet);
                    Resultados = new List<VerificaFicha_028EL>();
                    Resultados.Add(Resultado);
                    Cliente.Close();
                }
                else
                {
                    Resultado.Carnet = "";
                    Resultado.AfiliadoActivo = false;
                    Resultado.ExisteAfiliado = false;
                    Resultado.ExisteFicha = false;
                    Resultado.Mensaje = "Por favor Digitar un Carnet";
                    Resultados.Add(Resultado);
                }
                return gen.EscribirJson(new { data = Resultados, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }
        #endregion

        #region Información - Orientación
        public Stream GetFunEncuestaAll(string idDomVista)
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.EncuestaCategoria
                    .Where(r => r.idDomVista.Equals(idDomVista))
                    .Select(r => new
                    {
                        r.idEncuestaCategoria,
                        nombreEncuestaCategoria = r.codigoEncuestaCategoria + ". " + r.nombreEncuestaCategoria,
                        preguntas = r.EncuestaPregunta.Select(p => new
                        {
                            p.idEncuestaPregunta,
                            textoEncuestaPregunta = p.codigoEncuestaPregunta + ". " + p.textoEncuestaPregunta,
                            p.tipoPreEncuestaPregunta,
                            p.valorEncuestaPregunta,
                            literales = p.EncuestaLiteral.Select(l => new
                            {
                                l.idEncuestaLiteral,
                                textoEncuestaLiteral = l.liteEncuestaLiteral + ". " + l.textoEncuestaLiteral,
                                l.valorEncuestaLiteral,
                                l.checkedEncuestaLiteral
                            })
                            .ToList()
                        })
                        .ToList()
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream GetFunIpsAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Ips
                    .Select(r => new
                    {
                        r.idIps,
                        r.codigoIps,
                        r.identificacionIps,
                        r.razonIps,
                        nombreCompletoIps = r.codigoIps + " - " + r.razonIps
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream FunEncuestaIpsGuardar(EncuestaIpsModel encuestaIps, List<EncuestaIpsRespPregunta> respPregunta, List<EncuestaIpsRespLiteral> respLiteral)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var idEncuestaIps = db.EncuestaIps.Select(r => (int?)r.idEncuestaIps).Max();
                idEncuestaIps = (idEncuestaIps == null ? 1 : idEncuestaIps + 1);

                var datosEncuesta = new EncuestaIps
                {
                    idEncuestaIps = Convert.ToInt32(idEncuestaIps),
                    fechaHoraEncuestaIps = DateTime.Now,
                    idFuanAfiliado = encuestaIps.idFuanAfiliado,
                    idIps = encuestaIps.idIps,
                    observacionEncuestaIps = encuestaIps.observacionEncuestaIps,
                    idUsuario = encuestaIps.idUsuario
                };

                respPregunta.ForEach(r =>
                {
                    r.idEncuestaIps = Convert.ToInt32(idEncuestaIps);
                });

                respLiteral.ForEach(r =>
                {
                    r.idEncuestaIps = Convert.ToInt32(idEncuestaIps);
                });

                db.EncuestaIps.Add(datosEncuesta);
                db.EncuestaIpsRespPregunta.AddRange(respPregunta);
                db.EncuestaIpsRespLiteral.AddRange(respLiteral);

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

        public Stream FunEncuestaEpsGuardar(EncuestaEpsModel encuestaEps, List<EncuestaEpsRespPregunta> respPregunta, List<EncuestaEpsRespLiteral> respLiteral)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var idEncuestaEps = db.EncuestaEps.Select(r => (int?)r.idEncuestaEps).Max();
                idEncuestaEps = (idEncuestaEps == null ? 1 : idEncuestaEps + 1);

                var datosEncuesta = new EncuestaEps
                {
                    idEncuestaEps = Convert.ToInt32(idEncuestaEps),
                    fechaHoraEncuestaEps = DateTime.Now,
                    idFuanAfiliado = encuestaEps.idFuanAfiliado,
                    idIps = encuestaEps.idIps,
                    observacionEncuestaEps = encuestaEps.observacionEncuestaEps,
                    idUsuario = encuestaEps.idUsuario
                };
                
                db.EncuestaEps.Add(datosEncuesta);

                if (respPregunta.Count > 0)
                {
                    respPregunta.ForEach(r =>
                    {
                        r.idEncuestaEps = Convert.ToInt32(idEncuestaEps);
                    });

                    db.EncuestaEpsRespPregunta.AddRange(respPregunta);
                }

                if (respLiteral.Count > 0)
                {
                    respLiteral.ForEach(r =>
                    {
                        r.idEncuestaEps = Convert.ToInt32(idEncuestaEps);
                    });
                    
                    db.EncuestaEpsRespLiteral.AddRange(respLiteral);
                }

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
        #endregion

        #region Participación Social
        public Stream FunParSocListaAsistenciaGeneralGuardar(AsistenciaGeneralModel infoAsistencia, List<ListaAsistenciaGeneral> listaAsistencia)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                if (infoAsistencia.idAsistenciaGeneral != 0)
                {
                    var asistencia = db.AsistenciaGeneral.Where(r => r.idAsistenciaGeneral == infoAsistencia.idAsistenciaGeneral).FirstOrDefault();

                    asistencia.idCiudad = infoAsistencia.idCiudad;
                    asistencia.idGruposFocales = infoAsistencia.idGruposFocales;
                    asistencia.temaAsistenciaGeneral = infoAsistencia.temaAsistenciaGeneral;
                    asistencia.idModulo = infoAsistencia.idModulo;
                    asistencia.formadorAsistenciaGeneral = infoAsistencia.formadorAsistenciaGeneral;

                    var removeLista = db.ListaAsistenciaGeneral
                        .Where(r => r.idAsistenciaGeneral == asistencia.idAsistenciaGeneral)
                        .ToList();

                    if (removeLista.Count > 0)
                    {
                        db.ListaAsistenciaGeneral.RemoveRange(removeLista);
                    }

                    db.ListaAsistenciaGeneral.AddRange(listaAsistencia);
                }
                else { 
                    // obtengo ultimo id generado
                    var ultId = db.AsistenciaGeneral.Max(r => (int?)r.idAsistenciaGeneral);
                    ultId = (ultId == null ? 1 : ultId + 1);

                    infoAsistencia.idAsistenciaGeneral = Convert.ToInt32(ultId);

                    var asistencia = new AsistenciaGeneral
                    {
                        idAsistenciaGeneral = infoAsistencia.idAsistenciaGeneral,
                        idCiudad = infoAsistencia.idCiudad,
                        idGruposFocales = infoAsistencia.idGruposFocales,
                        temaAsistenciaGeneral = infoAsistencia.temaAsistenciaGeneral,
                        idModulo = infoAsistencia.idModulo,
                        formadorAsistenciaGeneral = infoAsistencia.formadorAsistenciaGeneral,
                        fechaAsistenciaGeneral = Convert.ToDateTime(infoAsistencia.fechaAsistenciaGeneral),
                        idUsuario = infoAsistencia.idUsuario
                    };

                    listaAsistencia.ForEach(r => {
                        r.idAsistenciaGeneral = Convert.ToInt32(ultId);
                    });

                    db.AsistenciaGeneral.Add(asistencia);
                    db.ListaAsistenciaGeneral.AddRange(listaAsistencia);
                }

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

        public Stream GetFunParSocAsistenciaGeneralAll()
        { 
            try
            {
                var db = new CoomuceEntities();

                var res = db.AsistenciaGeneral
                    .Select(r => new
                    {
                        r.idAsistenciaGeneral,
                        r.fechaAsistenciaGeneral,
                        r.Ciudad.idDepartamento,
                        compDepartamento = "(" + r.Ciudad.Departamento.codigoDepartamento + ") " + r.Ciudad.Departamento.nombreDepartamento,
                        r.idCiudad,
                        compCiudad = "(" + r.Ciudad.codigoCiudad + ") " + r.Ciudad.nombreCiudad,
                        r.idGruposFocales,
                        r.Modulo.Unidad.Eje.idEje,
                        r.Modulo.Unidad.idUnidad,
                        r.idModulo,
                        r.temaAsistenciaGeneral,
                        r.formadorAsistenciaGeneral,
                        listaAsistencia = r.ListaAsistenciaGeneral.Select(l => new
                        {
                            l.idAsistenciaGeneral,
                            l.idFuanAfiliado,
                            l.FuanAfiliado.identificacionFuanAfiliado,
                            l.FuanAfiliado.TipoIdentificacion.codigoTipoIdentificacion,
                            nombreCompletoAfiliado = l.FuanAfiliado.primerApellidoFuanAfiliado + " " + l.FuanAfiliado.segundoApellidoFuanAfiliado +
                                l.FuanAfiliado.primerNombreFuanAfiliado + " " + l.FuanAfiliado.segundoNombreFuanAfiliado,
                            l.FuanAfiliado.direccionFuanAfiliado,
                            l.FuanAfiliado.telefonoFuanAfiliado,
                            l.areaEntidadListaAsistenciaGeneral,
                            l.firmaListaAsistenciaGeneral
                        }).ToList()
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public string FunParSocImportarFirma()
        {
            try
            {
                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);
                var filename = "Firma_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                return filename;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string FunParSocImportarDocumento()
        {
            try
            {
                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);
                var filename = "Afiliacion_Documento_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                return filename;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string FunParSocImportarIncapacidadPermanente()
        {
            try
            {
                var file = gen.ObtenerArchivo();

                var path = gen.ObtenerRutaArchivos();

                var filePath = path + file.FileName;
                var extension = Path.GetExtension(filePath);
                var filename = "Afiliacion_Incapacidad_Permanente_" + Guid.NewGuid() + extension;
                path = path + filename;

                file.SaveAs(path);

                return filename;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion
    }
}
