using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

using Coomuce.DirectorServicios.Clases;
using Coomuce.DirectorServicios.Entidad;
using Coomuce.DirectorServicios.Modelos;
using Coomuce.DirectorServicios.Recursos;

namespace Coomuce.DirectorServicios
{
    [ServiceContract]
    public interface ICoomuceParametros
    {
        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void GetOptions();

        #region Interfaces Generales
        [OperationContract]
        [WebGet(UriTemplate = "GetTipoIdentificacionAll")]
        Stream GetParamTipoIdentificacionAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoIdentificacionCUD")]
        Stream ParamTipoIdentificacionCUD(List<TipoIdentificacion> nuevos, List<TipoIdentificacion> viejos, List<TipoIdentificacion> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoSexoAll")]
        Stream GetParamTipoSexoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoSexoCUD")]
        Stream ParamTipoSexoCUD(List<TipoSexo> nuevos, List<TipoSexo> viejos, List<TipoSexo> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoZonaAll")]
        Stream GetParamTipoZonaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoZonaCUD")]
        Stream ParamTipoZonaCUD(List<TipoZona> nuevos, List<TipoZona> viejos, List<TipoZona> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetGruposFocalesAll")]
        Stream GetParamGruposFocalesAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GruposFocalesCUD")]
        Stream ParamGruposFocalesCUD(List<GruposFocales> nuevos, List<GruposFocales> viejos, List<GruposFocales> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetIpsAll")]
        Stream GetParamIpsAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "IpsCUD")]
        Stream ParamIpsCUD(List<Ips> nuevos, List<Ips> viejos, List<Ips> eliminados);

        //[OperationContract]
        //[WebInvoke(
        //    BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "IpsImportar")]
        //Stream ParamIpsImportar(RemoteFileInfo archivo);
        #endregion

        #region Interfaces Actualización BD
        [OperationContract]
        [WebGet(UriTemplate = "GetTipoAfiliadoAll")]
        Stream GetParamTipoAfiliadoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoAfiliadoCUD")]
        Stream ParamTipoAfiliadoCUD(List<TipoAfiliado> nuevos, List<TipoAfiliado> viejos, List<TipoAfiliado> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoCotizanteAll")]
        Stream GetParamTipoCotizanteAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoCotizanteCUD")]
        Stream ParamTipoCotizanteCUD(List<TipoCotizante> nuevos, List<TipoCotizante> viejos, List<TipoCotizante> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoRegimenAll")]
        Stream GetParamTipoRegimenAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoRegimenCUD")]
        Stream ParamTipoRegimenCUD(List<TipoRegimen> nuevos, List<TipoRegimen> viejos, List<TipoRegimen> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoTramiteAll")]
        Stream GetParamTipoTramiteAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoTramiteCUD")]
        Stream ParamTipoTramiteCUD(List<TipoTramite> nuevos, List<TipoTramite> viejos, List<TipoTramite> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoParentescoAll")]
        Stream GetParamTipoParentescoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoParentescoCUD")]
        Stream ParamTipoParentescoCUD(List<TipoParentesco> nuevos, List<TipoParentesco> viejos, List<TipoParentesco> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoEtniaAll")]
        Stream GetParamTipoEtniaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoEtniaCUD")]
        Stream ParamTipoEtniaCUD(List<TipoEtnia> nuevos, List<TipoEtnia> viejos, List<TipoEtnia> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoNovedadAll")]
        Stream GetParamTipoNovedadAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoNovedadCUD")]
        Stream ParamTipoNovedadCUD(List<TipoNovedad> nuevos, List<TipoNovedad> viejos, List<TipoNovedad> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetGrupoPoblacionalAll")]
        Stream GetParamGrupoPoblacionalAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GrupoPoblacionalCUD")]
        Stream ParamGrupoPoblacionalCUD(List<GrupoPoblacional> nuevos, List<GrupoPoblacional> viejos, List<GrupoPoblacional> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetMotivoTrasladoAll")]
        Stream GetParamMotivoTrasladoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "MotivoTrasladoCUD")]
        Stream ParamMotivoTrasladoCUD(List<MotivoTraslado> nuevos, List<MotivoTraslado> viejos, List<MotivoTraslado> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoAfiliacionAll")]
        Stream GetParamTipoAfiliacionAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoAfiliacionCUD")]
        Stream ParamTipoAfiliacionCUD(List<TipoAfiliacion> nuevos, List<TipoAfiliacion> viejos, List<TipoAfiliacion> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoDiscapacidadAll")]
        Stream GetParamTipoDiscapacidadAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoDiscapacidadCUD")]
        Stream ParamTipoDiscapacidadCUD(List<TipoDiscapacidad> nuevos, List<TipoDiscapacidad> viejos, List<TipoDiscapacidad> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetCondicionDiscapacidadAll")]
        Stream GetParamCondicionDiscapacidadAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "CondicionDiscapacidadCUD")]
        Stream ParamCondicionDiscapacidadCUD(List<CondicionDiscapacidad> nuevos, List<CondicionDiscapacidad> viejos, List<CondicionDiscapacidad> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetDeclaracionAutorizacionAll")]
        Stream GetParamDeclaracionAutorizacionAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeclaracionAutorizacionCUD")]
        Stream ParamDeclaracionAutorizacionCUD(List<DeclaracionAutorizacion> nuevos, List<DeclaracionAutorizacion> viejos, List<DeclaracionAutorizacion> eliminados);
        #endregion

        #region Interfaces Caracterización Población
        [OperationContract]
        [WebGet(UriTemplate = "GetFactorRiesgoAll")]
        Stream GetParamFactorRiesgoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "FactorRiesgoCUD")]
        Stream ParamFactorRiesgoCUD(List<FactorRiesgo> nuevos, List<FactorRiesgo> viejos, List<FactorRiesgo> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetSubFactorRiesgoAll?idFactorRiesgo={idFactorRiesgo}")]
        Stream GetParamSubFactorRiesgoAll(byte idFactorRiesgo);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "SubFactorRiesgoCUD")]
        Stream ParamSubFactorRiesgoCUD(List<SubFactorRiesgo> nuevos, List<SubFactorRiesgo> viejos, List<SubFactorRiesgo> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetPreguntasSubFactorRiesgoAll?idSubFactorRiesgo={idSubFactorRiesgo}")]
        Stream GetParamPreguntasSubFactorRiesgoAll(byte idSubFactorRiesgo);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PreguntasSubFactorRiesgoCUD")]
        Stream ParamPreguntasSubFactorRiesgoCUD(List<PreguntasSubFactorRiesgo> nuevos, List<PreguntasSubFactorRiesgo> viejos, List<PreguntasSubFactorRiesgo> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetProcedenciaAll")]
        Stream GetParamProcedenciaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ProcedenciaCUD")]
        Stream ParamProcedenciaCUD(List<Procedencia> nuevos, List<Procedencia> viejos, List<Procedencia> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetNivelEducativoAll")]
        Stream GetParamNivelEducativoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "NivelEducativoCUD")]
        Stream ParamNivelEducativoCUD(List<NivelEducativo> nuevos, List<NivelEducativo> viejos, List<NivelEducativo> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetCondicionViviendaAll")]
        Stream GetParamCondicionViviendaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "CondicionViviendaCUD")]
        Stream ParamCondicionViviendaCUD(List<CondicionVivienda> nuevos, List<CondicionVivienda> viejos, List<CondicionVivienda> eliminados);
        
        [OperationContract]
        [WebGet(UriTemplate = "GetTipoViviendaAll")]
        Stream GetParamTipoViviendaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoViviendaCUD")]
        Stream ParamTipoViviendaCUD(List<TipoVivienda> nuevos, List<TipoVivienda> viejos, List<TipoVivienda> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTenenciaAll")]
        Stream GetParamTenenciaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TenenciaCUD")]
        Stream ParamTenenciaCUD(List<Tenencia> nuevos, List<Tenencia> viejos, List<Tenencia> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoCombustibleAll")]
        Stream GetParamTipoCombustibleAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoCombustibleCUD")]
        Stream ParamTipoCombustibleCUD(List<TipoCombustible> nuevos, List<TipoCombustible> viejos, List<TipoCombustible> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTratamientoAguaAll")]
        Stream GetParamTratamientoAguaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TratamientoAguaCUD")]
        Stream ParamTratamientoAguaCUD(List<TratamientoAgua> nuevos, List<TratamientoAgua> viejos, List<TratamientoAgua> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetDisposicionExcretaAll")]
        Stream GetParamDisposicionExcretaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DisposicionExcretaCUD")]
        Stream ParamDisposicionExcretaCUD(List<DisposicionExcreta> nuevos, List<DisposicionExcreta> viejos, List<DisposicionExcreta> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetDisposicionBasuraAll")]
        Stream GetParamDisposicionBasuraAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DisposicionBasuraCUD")]
        Stream ParamDisposicionBasuraCUD(List<DisposicionBasura> nuevos, List<DisposicionBasura> viejos, List<DisposicionBasura> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetTipoAnimalAll")]
        Stream GetParamTipoAnimalAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoAnimalCUD")]
        Stream ParamTipoAnimalCUD(List<TipoAnimal> nuevos, List<TipoAnimal> viejos, List<TipoAnimal> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetCicloVitalAll")]
        Stream GetParamCicloVitalAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "CicloVitalCUD")]
        Stream ParamCicloVitalCUD(List<CicloVital> nuevos, List<CicloVital> viejos, List<CicloVital> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetPreguntasCicloVitalAll?idCicloVital={idCicloVital}&idTipoSexo={idTipoSexo}")]
        Stream GetParamPreguntasCicloVitalAll(byte idCicloVital, byte idTipoSexo);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PreguntasCicloVitalCUD")]
        Stream ParamPreguntasCicloVitalCUD(byte idCicloVital, byte idTipoSexo, List<CicloVitalPreguntasSubFactorRiesgo> nuevos);

        [OperationContract]
        [WebGet(UriTemplate = "GetPreguntasCicloVitalGestanteAll")]
        Stream GetParamPreguntasCicloVitalGestanteAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PreguntasCicloVitalGestanteCUD")]
        Stream ParamPreguntasCicloVitalGestanteCUD(List<CicloVitalGestante> nuevos);
        #endregion

        #region Interfaces Demanda Inducida
        [OperationContract]
        [WebGet(UriTemplate = "GetTipoVisitaDomiciliariaAll")]
        Stream GetParamTipoVisitaDomiciliariaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "TipoVisitaDomiciliariaCUD")]
        Stream ParamTipoVisitaDomiciliariaCUD(List<TipoVisitaDomiciliaria> nuevos, List<TipoVisitaDomiciliaria> viejos, List<TipoVisitaDomiciliaria> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetProgramaResolucion412All")]
        Stream GetParamProgramaResolucion412All();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ProgramaResolucion412CUD")]
        Stream ParamProgramaResolucion412CUD(List<ProgramaResolucion412> nuevos, List<ProgramaResolucion412> viejos, List<ProgramaResolucion412> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetSeguimientoProgramasIntervencionRiesgoAll")]
        Stream GetParamSeguimientoProgramasIntervencionRiesgoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "SeguimientoProgramasIntervencionRiesgoCUD")]
        Stream ParamSeguimientoProgramasIntervencionRiesgoCUD(List<SeguimientoProgramasIntervencionRiesgo> nuevos, List<SeguimientoProgramasIntervencionRiesgo> viejos, List<SeguimientoProgramasIntervencionRiesgo> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetGrupoInteresAll")]
        Stream GetParamGrupoInteresAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GrupoInteresCUD")]
        Stream ParamGrupoInteresCUD(List<GrupoInteres> nuevos, List<GrupoInteres> viejos, List<GrupoInteres> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetMotivoContactoAll")]
        Stream GetParamMotivoContactoAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "MotivoContactoCUD")]
        Stream ParamMotivoContactoCUD(List<MotivoContacto> nuevos, List<MotivoContacto> viejos, List<MotivoContacto> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetMotivoConsultaAll")]
        Stream GetParamMotivoConsultaAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "MotivoConsultaCUD")]
        Stream ParamMotivoConsultaCUD(List<MotivoConsulta> nuevos, List<MotivoConsulta> viejos, List<MotivoConsulta> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetPiezasInformativasAll")]
        Stream GetParamPiezasInformativasAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "PiezasInformativasCUD")]
        Stream ParamPiezasInformativasCUD(List<PiezasInformativas> nuevos, List<PiezasInformativas> viejos, List<PiezasInformativas> eliminados);
        #endregion

        #region Interfaces Información - Orientación
        [OperationContract]
        [WebGet(UriTemplate = "GetEncuestaCategoriaAll?idDomVista={idDomVista}")]
        Stream GetParamEncuestaCategoriaAll(string idDomVista);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "EncuestaCategoriaCUD")]
        Stream ParamEncuestaCategoriaCUD(List<EncuestaCategoria> nuevos, List<EncuestaCategoria> viejos, List<EncuestaCategoria> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetEncuestaPreguntaAll?idEncuestaCategoria={idEncuestaCategoria}")]
        Stream GetParamEncuestaPreguntaAll(byte idEncuestaCategoria);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "EncuestaPreguntaCUD")]
        Stream ParamEncuestaPreguntaCUD(List<EncuestaPregunta> nuevos, List<EncuestaPregunta> viejos, List<EncuestaPregunta> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetEncuestaLiteralAll?idEncuestaPregunta={idEncuestaPregunta}")]
        Stream GetParamEncuestaLiteralAll(short idEncuestaPregunta);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "EncuestaLiteralCUD")]
        Stream ParamEncuestaLiteralCUD(List<EncuestaLiteral> nuevos, List<EncuestaLiteral> viejos, List<EncuestaLiteral> eliminados);
        #endregion

        #region Interfaces Participación Social
        [OperationContract]
        [WebGet(UriTemplate = "GetEjeAll")]
        Stream GetParamEjeAll();

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "EjeCUD")]
        Stream ParamEjeCUD(List<Eje> nuevos, List<Eje> viejos, List<Eje> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetUnidadAll?idEje={idEje}")]
        Stream GetParamUnidadAll(byte idEje);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UnidadCUD")]
        Stream ParamUnidadCUD(List<Unidad> nuevos, List<Unidad> viejos, List<Unidad> eliminados);

        [OperationContract]
        [WebGet(UriTemplate = "GetModuloAll?idUnidad={idUnidad}")]
        Stream GetParamModuloAll(short idUnidad);

        [OperationContract]
        [WebInvoke(
            BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, UriTemplate = "ModuloCUD")]
        Stream ParamModuloCUD(List<Modulo> nuevos, List<Modulo> viejos, List<Modulo> eliminados);
        #endregion
    }

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class CoomuceParametros : ICoomuceParametros
    {
        Generales gen = new Generales();

        public void GetOptions()
        {
        }

        #region Generales
        public Stream GetParamTipoSexoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoSexo
                    .Select(r => new
                    {
                        r.idTipoSexo,
                        r.codigoTipoSexo,
                        r.nombreTipoSexo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoSexoCUD(List<TipoSexo> nuevos, List<TipoSexo> viejos, List<TipoSexo> eliminados)
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
                    db.TipoSexo.RemoveRange(eliminados);
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
                    db.TipoSexo.AddRange(nuevos);
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

        public Stream GetParamTipoIdentificacionAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoIdentificacion
                    .Select(r => new
                    {
                        r.idTipoIdentificacion,
                        r.codigoTipoIdentificacion,
                        r.nombreTipoIdentificacion
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoIdentificacionCUD(List<TipoIdentificacion> nuevos, List<TipoIdentificacion> viejos, List<TipoIdentificacion> eliminados)
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
                    db.TipoIdentificacion.RemoveRange(eliminados);
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
                    db.TipoIdentificacion.AddRange(nuevos);
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

        public Stream GetParamTipoZonaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoZona
                    .Select(r => new
                    {
                        r.idTipoZona,
                        r.codigoTipoZona,
                        r.nombreTipoZona
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoZonaCUD(List<TipoZona> nuevos, List<TipoZona> viejos, List<TipoZona> eliminados)
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
                    db.TipoZona.RemoveRange(eliminados);
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
                    db.TipoZona.AddRange(nuevos);
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

        public Stream GetParamGruposFocalesAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.GruposFocales
                    .Select(r => new
                    {
                        r.idGruposFocales,
                        r.codigoGruposFocales,
                        r.nombreGruposFocales
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamGruposFocalesCUD(List<GruposFocales> nuevos, List<GruposFocales> viejos, List<GruposFocales> eliminados)
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
                    db.GruposFocales.RemoveRange(eliminados);
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
                    db.GruposFocales.AddRange(nuevos);
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

        public Stream GetParamIpsAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Ips
                    .Select(r => new
                    {
                        r.idIps,
                        r.codigoIps,
                        r.razonIps,
                        r.idTipoIdentificacion,
                        compTipoIdentificacion = r.TipoIdentificacion.codigoTipoIdentificacion + " - " + r.TipoIdentificacion.nombreTipoIdentificacion,
                        r.identificacionIps,
                        r.direccionIps,
                        r.telefonoIps,
                        r.Ciudad.idDepartamento,
                        compDepartamento = r.Ciudad.Departamento.codigoDepartamento + " - " + r.Ciudad.Departamento.nombreDepartamento,
                        r.idCiudad,
                        compCiudad = r.Ciudad.codigoCiudad + " - " + r.Ciudad.nombreCiudad,
                        r.representanteIps,
                        r.nivelIps,
                        r.contactoIps,
                        r.emailIps
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamIpsCUD(List<Ips> nuevos, List<Ips> viejos, List<Ips> eliminados)
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
                    db.Ips.RemoveRange(eliminados);
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
                    db.Ips.AddRange(nuevos);
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
        #endregion

        #region Actualización BD
        public Stream GetParamTipoAfiliadoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoAfiliado
                    .Select(r => new
                    {
                        r.idTipoAfiliado,
                        r.codigoTipoAfiliado,
                        r.nombreTipoAfiliado
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoAfiliadoCUD(List<TipoAfiliado> nuevos, List<TipoAfiliado> viejos, List<TipoAfiliado> eliminados)
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
                    db.TipoAfiliado.RemoveRange(eliminados);
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
                    db.TipoAfiliado.AddRange(nuevos);
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

        public Stream GetParamTipoCotizanteAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoCotizante
                    .Select(r => new
                    {
                        r.idTipoCotizante,
                        r.codigoTipoCotizante,
                        r.nombreTipoCotizante
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoCotizanteCUD(List<TipoCotizante> nuevos, List<TipoCotizante> viejos, List<TipoCotizante> eliminados)
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
                    db.TipoCotizante.RemoveRange(eliminados);
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
                    db.TipoCotizante.AddRange(nuevos);
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

        public Stream GetParamTipoRegimenAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoRegimen
                    .Select(r => new
                    {
                        r.idTipoRegimen,
                        r.codigoTipoRegimen,
                        r.nombreTipoRegimen
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoRegimenCUD(List<TipoRegimen> nuevos, List<TipoRegimen> viejos, List<TipoRegimen> eliminados)
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
                    db.TipoRegimen.RemoveRange(eliminados);
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
                    db.TipoRegimen.AddRange(nuevos);
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

        public Stream GetParamTipoTramiteAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoTramite
                    .Select(r => new
                    {
                        r.idTipoTramite,
                        r.codigoTipoTramite,
                        r.nombreTipoTramite
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoTramiteCUD(List<TipoTramite> nuevos, List<TipoTramite> viejos, List<TipoTramite> eliminados)
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
                    db.TipoTramite.RemoveRange(eliminados);
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
                    db.TipoTramite.AddRange(nuevos);
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

        public Stream GetParamTipoParentescoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoParentesco
                    .Select(r => new
                    {
                        r.idTipoParentesco,
                        r.codigoTipoParentesco,
                        r.nombreTipoParentesco,
                        r.descripcionTipoParentesco
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoParentescoCUD(List<TipoParentesco> nuevos, List<TipoParentesco> viejos, List<TipoParentesco> eliminados)
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
                    db.TipoParentesco.RemoveRange(eliminados);
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
                    db.TipoParentesco.AddRange(nuevos);
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

        public Stream GetParamTipoEtniaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoEtnia
                    .Select(r => new
                    {
                        r.idTipoEtnia,
                        r.codigoTipoEtnia,
                        r.nombreTipoEtnia
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoEtniaCUD(List<TipoEtnia> nuevos, List<TipoEtnia> viejos, List<TipoEtnia> eliminados)
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
                    db.TipoEtnia.RemoveRange(eliminados);
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
                    db.TipoEtnia.AddRange(nuevos);
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

        public Stream GetParamGrupoPoblacionalAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.GrupoPoblacional
                    .Select(r => new
                    {
                        r.idGrupoPoblacional,
                        r.codigoGrupoPoblacional,
                        r.nombreGrupoPoblacional
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamGrupoPoblacionalCUD(List<GrupoPoblacional> nuevos, List<GrupoPoblacional> viejos, List<GrupoPoblacional> eliminados)
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
                    db.GrupoPoblacional.RemoveRange(eliminados);
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
                    db.GrupoPoblacional.AddRange(nuevos);
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

        public Stream GetParamTipoNovedadAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoNovedad
                    .Select(r => new
                    {
                        r.idTipoNovedad,
                        r.codigoTipoNovedad,
                        r.nombreTipoNovedad,
                        r.tipoValorCampoTipoNovedad,
                        r.valorCampoTipoNovedad
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoNovedadCUD(List<TipoNovedad> nuevos, List<TipoNovedad> viejos, List<TipoNovedad> eliminados)
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
                    db.TipoNovedad.RemoveRange(eliminados);
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
                    db.TipoNovedad.AddRange(nuevos);
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

        public Stream GetParamMotivoTrasladoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.MotivoTraslado
                    .Select(r => new
                    {
                        r.idMotivoTraslado,
                        r.codigoMotivoTraslado,
                        r.descripcionMotivoTraslado
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamMotivoTrasladoCUD(List<MotivoTraslado> nuevos, List<MotivoTraslado> viejos, List<MotivoTraslado> eliminados)
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
                    db.MotivoTraslado.RemoveRange(eliminados);
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
                    db.MotivoTraslado.AddRange(nuevos);
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

        public Stream GetParamTipoAfiliacionAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoAfiliacion
                    .Select(r => new
                    {
                        r.idTipoAfiliacion,
                        r.codigoTipoAfiliacion,
                        r.nombreTipoAfiliacion
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoAfiliacionCUD(List<TipoAfiliacion> nuevos, List<TipoAfiliacion> viejos, List<TipoAfiliacion> eliminados)
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
                    db.TipoAfiliacion.RemoveRange(eliminados);
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
                    db.TipoAfiliacion.AddRange(nuevos);
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

        public Stream GetParamTipoDiscapacidadAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoDiscapacidad
                    .Select(r => new
                    {
                        r.idTipoDiscapacidad,
                        r.codigoTipoDiscapacidad,
                        r.nombreTipoDiscapacidad
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoDiscapacidadCUD(List<TipoDiscapacidad> nuevos, List<TipoDiscapacidad> viejos, List<TipoDiscapacidad> eliminados)
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
                    db.TipoDiscapacidad.RemoveRange(eliminados);
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
                    db.TipoDiscapacidad.AddRange(nuevos);
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

        public Stream GetParamCondicionDiscapacidadAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.CondicionDiscapacidad
                    .Select(r => new
                    {
                        r.idCondicionDiscapacidad,
                        r.codigoCondicionDiscapacidad,
                        r.nombreCondicionDiscapacidad
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamCondicionDiscapacidadCUD(List<CondicionDiscapacidad> nuevos, List<CondicionDiscapacidad> viejos, List<CondicionDiscapacidad> eliminados)
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
                    db.CondicionDiscapacidad.RemoveRange(eliminados);
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
                    db.CondicionDiscapacidad.AddRange(nuevos);
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

        public Stream GetParamDeclaracionAutorizacionAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.DeclaracionAutorizacion
                    .Select(r => new
                    {
                        r.idDeclaracionAutorizacion,
                        r.codigoDeclaracionAutorizacion,
                        r.descripcionDeclaracionAutorizacion
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamDeclaracionAutorizacionCUD(List<DeclaracionAutorizacion> nuevos, List<DeclaracionAutorizacion> viejos, List<DeclaracionAutorizacion> eliminados)
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
                    db.DeclaracionAutorizacion.RemoveRange(eliminados);
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
                    db.DeclaracionAutorizacion.AddRange(nuevos);
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
        #endregion

        #region Caracterización Población
        public Stream GetParamFactorRiesgoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.FactorRiesgo
                    .Select(r => new
                    {
                        r.idFactorRiesgo,
                        r.codigoFactorRiesgo,
                        r.nombreFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamFactorRiesgoCUD(List<FactorRiesgo> nuevos, List<FactorRiesgo> viejos, List<FactorRiesgo> eliminados)
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
                    db.FactorRiesgo.RemoveRange(eliminados);
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
                    db.FactorRiesgo.AddRange(nuevos);
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

        public Stream GetParamSubFactorRiesgoAll(byte idFactorRiesgo)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.SubFactorRiesgo.Max(r => (byte?)r.idSubFactorRiesgo);
                if (max == null) max = 0;

                var res = db.SubFactorRiesgo
                    .Where(r => r.idFactorRiesgo.Equals(idFactorRiesgo))
                    .Select(r => new
                    {
                        r.idSubFactorRiesgo,
                        r.idFactorRiesgo,
                        r.codigoSubFactorRiesgo,
                        r.nombreSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamSubFactorRiesgoCUD(List<SubFactorRiesgo> nuevos, List<SubFactorRiesgo> viejos, List<SubFactorRiesgo> eliminados)
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
                    db.SubFactorRiesgo.RemoveRange(eliminados);
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
                    db.SubFactorRiesgo.AddRange(nuevos);
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

        public Stream GetParamPreguntasSubFactorRiesgoAll(byte idSubFactorRiesgo)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.PreguntasSubFactorRiesgo.Max(r => (short?)r.idPreguntasSubFactorRiesgo);
                if (max == null) max = 0;

                var res = db.PreguntasSubFactorRiesgo
                    .Where(r => r.idSubFactorRiesgo.Equals(idSubFactorRiesgo))
                    .Select(r => new
                    {
                        r.idPreguntasSubFactorRiesgo,
                        r.idSubFactorRiesgo,
                        r.codigoPreguntasSubFactorRiesgo,
                        r.descripcionPreguntasSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamPreguntasSubFactorRiesgoCUD(List<PreguntasSubFactorRiesgo> nuevos, List<PreguntasSubFactorRiesgo> viejos, List<PreguntasSubFactorRiesgo> eliminados)
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
                    db.PreguntasSubFactorRiesgo.RemoveRange(eliminados);
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
                    db.PreguntasSubFactorRiesgo.AddRange(nuevos);
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

        public Stream GetParamProcedenciaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Procedencia
                    .Select(r => new
                    {
                        r.idProcedencia,
                        r.codigoProcedencia,
                        r.nombreProcedencia
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamProcedenciaCUD(List<Procedencia> nuevos, List<Procedencia> viejos, List<Procedencia> eliminados)
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
                    db.Procedencia.RemoveRange(eliminados);
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
                    db.Procedencia.AddRange(nuevos);
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

        public Stream GetParamNivelEducativoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.NivelEducativo
                    .Select(r => new
                    {
                        r.idNivelEducativo,
                        r.codigoNivelEducativo,
                        r.nombreNivelEducativo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamNivelEducativoCUD(List<NivelEducativo> nuevos, List<NivelEducativo> viejos, List<NivelEducativo> eliminados)
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
                    db.NivelEducativo.RemoveRange(eliminados);
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
                    db.NivelEducativo.AddRange(nuevos);
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

        public Stream GetParamCondicionViviendaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.CondicionVivienda
                    .Select(r => new
                    {
                        r.idCondicionVivienda,
                        r.nombreCondicionVivienda
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamCondicionViviendaCUD(List<CondicionVivienda> nuevos, List<CondicionVivienda> viejos, List<CondicionVivienda> eliminados)
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
                    db.CondicionVivienda.RemoveRange(eliminados);
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
                    db.CondicionVivienda.AddRange(nuevos);
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

        public Stream GetParamTipoViviendaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoVivienda
                    .Select(r => new
                    {
                        r.idTipoVivienda,
                        r.codigoTipoVivienda,
                        r.nombreTipoVivienda
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoViviendaCUD(List<TipoVivienda> nuevos, List<TipoVivienda> viejos, List<TipoVivienda> eliminados)
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
                    db.TipoVivienda.RemoveRange(eliminados);
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
                    db.TipoVivienda.AddRange(nuevos);
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

        public Stream GetParamTenenciaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Tenencia
                    .Select(r => new
                    {
                        r.idTenencia,
                        r.codigoTenencia,
                        r.nombreTenencia
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTenenciaCUD(List<Tenencia> nuevos, List<Tenencia> viejos, List<Tenencia> eliminados)
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
                    db.Tenencia.RemoveRange(eliminados);
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
                    db.Tenencia.AddRange(nuevos);
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

        public Stream GetParamTipoCombustibleAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoCombustible
                    .Select(r => new
                    {
                        r.idTipoCombustible,
                        r.codigoTipoCombustible,
                        r.nombreTipoCombustible
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoCombustibleCUD(List<TipoCombustible> nuevos, List<TipoCombustible> viejos, List<TipoCombustible> eliminados)
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
                    db.TipoCombustible.RemoveRange(eliminados);
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
                    db.TipoCombustible.AddRange(nuevos);
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

        public Stream GetParamTratamientoAguaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TratamientoAgua
                    .Select(r => new
                    {
                        r.idTratamientoAgua,
                        r.codigoTratamientoAgua,
                        r.nombreTratamientoAgua
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTratamientoAguaCUD(List<TratamientoAgua> nuevos, List<TratamientoAgua> viejos, List<TratamientoAgua> eliminados)
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
                    db.TratamientoAgua.RemoveRange(eliminados);
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
                    db.TratamientoAgua.AddRange(nuevos);
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

        public Stream GetParamDisposicionExcretaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.DisposicionExcreta
                    .Select(r => new
                    {
                        r.idDisposicionExcreta,
                        r.codigoDisposicionExcreta,
                        r.nombreDisposicionExcreta
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamDisposicionExcretaCUD(List<DisposicionExcreta> nuevos, List<DisposicionExcreta> viejos, List<DisposicionExcreta> eliminados)
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
                    db.DisposicionExcreta.RemoveRange(eliminados);
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
                    db.DisposicionExcreta.AddRange(nuevos);
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

        public Stream GetParamDisposicionBasuraAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.DisposicionBasura
                    .Select(r => new
                    {
                        r.idDisposicionBasura,
                        r.codigoDisposicionBasura,
                        r.nombreDisposicionBasura
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamDisposicionBasuraCUD(List<DisposicionBasura> nuevos, List<DisposicionBasura> viejos, List<DisposicionBasura> eliminados)
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
                    db.DisposicionBasura.RemoveRange(eliminados);
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
                    db.DisposicionBasura.AddRange(nuevos);
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

        public Stream GetParamTipoAnimalAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoAnimal
                    .Select(r => new
                    {
                        r.idTipoAnimal,
                        r.codigoTipoAnimal,
                        r.nombreTipoAnimal
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoAnimalCUD(List<TipoAnimal> nuevos, List<TipoAnimal> viejos, List<TipoAnimal> eliminados)
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
                    db.TipoAnimal.RemoveRange(eliminados);
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
                    db.TipoAnimal.AddRange(nuevos);
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
        
        public Stream GetParamCicloVitalAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.CicloVital
                    .Select(r => new
                    {
                        r.idCicloVital,
                        r.edadMinCicloVital,
                        r.edadMaxCicloVital
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamCicloVitalCUD(List<CicloVital> nuevos, List<CicloVital> viejos, List<CicloVital> eliminados)
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
                    db.CicloVital.RemoveRange(eliminados);
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
                    db.CicloVital.AddRange(nuevos);
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

        public Stream GetParamPreguntasCicloVitalAll(byte idCicloVital, byte idTipoSexo)
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.CicloVitalPreguntasSubFactorRiesgo
                    .Where(r => r.idCicloVital == idCicloVital && r.idTipoSexo == idTipoSexo)
                    .Select(r => new
                    {
                        r.idCicloVital,
                        compCicloVital = r.CicloVital.edadMinCicloVital.ToString() + " - " + r.CicloVital.edadMaxCicloVital.ToString(),
                        r.idTipoSexo,
                        compTipoSexo = "(" + r.TipoSexo.codigoTipoSexo + ") " + r.TipoSexo.nombreTipoSexo,
                        r.idPreguntasSubFactorRiesgo,
                        compPreguntasSubFactorRiesgo = "(" + r.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo + ") " + r.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamPreguntasCicloVitalCUD(byte idCicloVital, byte idTipoSexo, List<CicloVitalPreguntasSubFactorRiesgo> nuevos)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var itemsEliminar = db.CicloVitalPreguntasSubFactorRiesgo.Where(r => r.idCicloVital == idCicloVital && r.idTipoSexo == idTipoSexo).ToList();

                db.CicloVitalPreguntasSubFactorRiesgo.RemoveRange(itemsEliminar);

                db.CicloVitalPreguntasSubFactorRiesgo.AddRange(nuevos);

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

        public Stream GetParamPreguntasCicloVitalGestanteAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.CicloVitalGestante
                    .Select(r => new
                    {
                        r.idCicloVitalGestante,
                        compFactorRiesgo = "(" + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.FactorRiesgo.codigoFactorRiesgo + ") " + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.FactorRiesgo.nombreFactorRiesgo,
                        compSubFactorRiesgo = "(" + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.codigoSubFactorRiesgo + ") " + r.PreguntasSubFactorRiesgo.SubFactorRiesgo.nombreSubFactorRiesgo,
                        r.idPreguntasSubFactorRiesgo,
                        compPreguntasSubFactorRiesgo = "(" + r.PreguntasSubFactorRiesgo.codigoPreguntasSubFactorRiesgo + ") " + r.PreguntasSubFactorRiesgo.descripcionPreguntasSubFactorRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamPreguntasCicloVitalGestanteCUD(List<CicloVitalGestante> nuevos)
        {
            var db = new CoomuceEntities();
            var transaction = db.Database.BeginTransaction();

            try
            {
                var itemsEliminar = db.CicloVitalGestante.ToList();

                if (itemsEliminar.Count > 0)
                {
                    db.CicloVitalGestante.RemoveRange(itemsEliminar);
                }

                db.CicloVitalGestante.AddRange(nuevos);

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
        #endregion

        #region Demanda Inducida
        public Stream GetParamTipoVisitaDomiciliariaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.TipoVisitaDomiciliaria
                    .Select(r => new
                    {
                        r.idTipoVisitaDomiciliaria,
                        r.codigoTipoVisitaDomiciliaria,
                        r.nombreTipoVisitaDomiciliaria
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamTipoVisitaDomiciliariaCUD(List<TipoVisitaDomiciliaria> nuevos, List<TipoVisitaDomiciliaria> viejos, List<TipoVisitaDomiciliaria> eliminados)
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
                    db.TipoVisitaDomiciliaria.RemoveRange(eliminados);
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
                    db.TipoVisitaDomiciliaria.AddRange(nuevos);
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

        public Stream GetParamProgramaResolucion412All()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.ProgramaResolucion412
                    .Select(r => new
                    {
                        r.idProgramaResolucion412,
                        r.codigoProgramaResolucion412,
                        r.descripcionProgramaResolucion412
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamProgramaResolucion412CUD(List<ProgramaResolucion412> nuevos, List<ProgramaResolucion412> viejos, List<ProgramaResolucion412> eliminados)
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
                    db.ProgramaResolucion412.RemoveRange(eliminados);
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
                    db.ProgramaResolucion412.AddRange(nuevos);
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

        public Stream GetParamSeguimientoProgramasIntervencionRiesgoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.SeguimientoProgramasIntervencionRiesgo
                    .Select(r => new
                    {
                        r.idSeguimientoProgramasIntervencionRiesgo,
                        r.codigoSeguimientoProgramasIntervencionRiesgo,
                        r.nombreSeguimientoProgramasIntervencionRiesgo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamSeguimientoProgramasIntervencionRiesgoCUD(List<SeguimientoProgramasIntervencionRiesgo> nuevos, List<SeguimientoProgramasIntervencionRiesgo> viejos, List<SeguimientoProgramasIntervencionRiesgo> eliminados)
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
                    db.SeguimientoProgramasIntervencionRiesgo.RemoveRange(eliminados);
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
                    db.SeguimientoProgramasIntervencionRiesgo.AddRange(nuevos);
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

        public Stream GetParamGrupoInteresAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.GrupoInteres
                    .Select(r => new
                    {
                        r.idGrupoInteres,
                        r.codigoGrupoInteres,
                        r.descripcionGrupoInteres
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamGrupoInteresCUD(List<GrupoInteres> nuevos, List<GrupoInteres> viejos, List<GrupoInteres> eliminados)
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
                    db.GrupoInteres.RemoveRange(eliminados);
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
                    db.GrupoInteres.AddRange(nuevos);
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

        public Stream GetParamMotivoContactoAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.MotivoContacto
                    .Select(r => new
                    {
                        r.idMotivoContacto,
                        r.codigoMotivoContacto,
                        r.descripcionMotivoContacto
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamMotivoContactoCUD(List<MotivoContacto> nuevos, List<MotivoContacto> viejos, List<MotivoContacto> eliminados)
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
                    db.MotivoContacto.RemoveRange(eliminados);
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
                    db.MotivoContacto.AddRange(nuevos);
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

        public Stream GetParamMotivoConsultaAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.MotivoConsulta
                    .Select(r => new
                    {
                        r.idMotivoConsulta,
                        r.codigoMotivoConsulta,
                        r.descripcionMotivoConsulta
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamMotivoConsultaCUD(List<MotivoConsulta> nuevos, List<MotivoConsulta> viejos, List<MotivoConsulta> eliminados)
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
                    db.MotivoConsulta.RemoveRange(eliminados);
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
                    db.MotivoConsulta.AddRange(nuevos);
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

        public Stream GetParamPiezasInformativasAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.PiezasInformativas
                    .Select(r => new
                    {
                        r.idPiezasInformativas,
                        r.codigoPiezasInformativas,
                        r.descripcionPiezasInformativas
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamPiezasInformativasCUD(List<PiezasInformativas> nuevos, List<PiezasInformativas> viejos, List<PiezasInformativas> eliminados)
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
                    db.PiezasInformativas.RemoveRange(eliminados);
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
                    db.PiezasInformativas.AddRange(nuevos);
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
        #endregion

        #region Información - Orientación
        public Stream GetParamEncuestaCategoriaAll(string idDomVista)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.EncuestaCategoria.Max(r => (byte?)r.idEncuestaCategoria);
                if (max == null) max = 0;

                var res = db.EncuestaCategoria
                    .Where(r => r.idDomVista.Equals(idDomVista))
                    .Select(r => new
                    {
                        r.idEncuestaCategoria,
                        r.idDomVista,
                        r.codigoEncuestaCategoria,
                        r.nombreEncuestaCategoria,
                        r.ordenEncuestaCategoria
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamEncuestaCategoriaCUD(List<EncuestaCategoria> nuevos, List<EncuestaCategoria> viejos, List<EncuestaCategoria> eliminados)
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
                    db.EncuestaCategoria.RemoveRange(eliminados);
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
                    db.EncuestaCategoria.AddRange(nuevos);
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

        public Stream GetParamEncuestaPreguntaAll(byte idEncuestaCategoria)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.EncuestaPregunta.Max(r => (byte?)r.idEncuestaPregunta);
                if (max == null) max = 0;

                var res = db.EncuestaPregunta
                    .Where(r => r.idEncuestaCategoria.Equals(idEncuestaCategoria))
                    .Select(r => new
                    {
                        r.idEncuestaPregunta,
                        r.idEncuestaCategoria,
                        r.codigoEncuestaPregunta,
                        r.textoEncuestaPregunta,
                        r.tipoPreEncuestaPregunta,
                        r.valorEncuestaPregunta
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamEncuestaPreguntaCUD(List<EncuestaPregunta> nuevos, List<EncuestaPregunta> viejos, List<EncuestaPregunta> eliminados)
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
                    db.EncuestaPregunta.RemoveRange(eliminados);
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
                    db.EncuestaPregunta.AddRange(nuevos);
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

        public Stream GetParamEncuestaLiteralAll(short idEncuestaPregunta)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.EncuestaLiteral.Max(r => (byte?)r.idEncuestaLiteral);
                if (max == null) max = 0;

                var res = db.EncuestaLiteral
                    .Where(r => r.idEncuestaPregunta.Equals(idEncuestaPregunta))
                    .Select(r => new
                    {
                        r.idEncuestaPregunta,
                        r.idEncuestaLiteral,
                        r.liteEncuestaLiteral,
                        r.textoEncuestaLiteral,
                        r.valorEncuestaLiteral,
                        r.checkedEncuestaLiteral
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamEncuestaLiteralCUD(List<EncuestaLiteral> nuevos, List<EncuestaLiteral> viejos, List<EncuestaLiteral> eliminados)
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
                    db.EncuestaLiteral.RemoveRange(eliminados);
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
                    db.EncuestaLiteral.AddRange(nuevos);
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
        #endregion

        #region Participación Social
        public Stream GetParamEjeAll()
        {
            try
            {
                var db = new CoomuceEntities();

                var res = db.Eje
                    .Select(r => new
                    {
                        r.idEje,
                        r.codigoEje,
                        r.nombreEje
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamEjeCUD(List<Eje> nuevos, List<Eje> viejos, List<Eje> eliminados)
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
                    db.Eje.RemoveRange(eliminados);
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
                    db.Eje.AddRange(nuevos);
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

        public Stream GetParamUnidadAll(byte idEje)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.Unidad.Max(r => (short?)r.idUnidad);
                if (max == null) max = 0;

                var res = db.Unidad
                    .Where(r => r.idEje.Equals(idEje))
                    .Select(r => new
                    {
                        r.idEje,
                        r.idUnidad,
                        r.codigoUnidad,
                        r.nombreUnidad
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamUnidadCUD(List<Unidad> nuevos, List<Unidad> viejos, List<Unidad> eliminados)
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
                    db.Unidad.RemoveRange(eliminados);
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
                    db.Unidad.AddRange(nuevos);
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

        public Stream GetParamModuloAll(short idUnidad)
        {
            try
            {
                var db = new CoomuceEntities();

                // obtengo el máximo id generado
                var max = db.Modulo.Max(r => (short?)r.idModulo);
                if (max == null) max = 0;

                var res = db.Modulo
                    .Where(r => r.idUnidad.Equals(idUnidad))
                    .Select(r => new
                    {
                        r.idUnidad,
                        r.idModulo,
                        r.codigoModulo,
                        r.nombreModulo
                    })
                    .ToList();

                return gen.EscribirJson(new { data = res, identity = max, total = res.Count, success = true });
            }
            catch (Exception ex)
            {
                return gen.EscribirJson(new { message = string.Format(Mensajes.Error, ex.Message), success = false });
            }
        }

        public Stream ParamModuloCUD(List<Modulo> nuevos, List<Modulo> viejos, List<Modulo> eliminados)
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
                    db.Modulo.RemoveRange(eliminados);
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
                    db.Modulo.AddRange(nuevos);
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
        #endregion
    }
}
