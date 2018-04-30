using System.Collections.Generic;

namespace Coomuce.DirectorServicios.Modelos
{
    public class PurisuModel
    {
        public int idInfoPurisu { get; set; }
        public int idPurisu { get; set; }
        public int idFuanAfiliado { get; set; }
        public string numCarnePurisu { get; set; }
        public byte? idTipoVisitaDomiciliaria { get; set; }
        public bool usisPurisu { get; set; }
        public bool ipsPrimariaPurisu { get; set; }
        public bool telefonicaPurisu { get; set; }
        public bool cauPurisu { get; set; }
        public bool actividadExtramuralPurisu { get; set; }
        public byte? idProgramaResolucion412 { get; set; }
        public byte? idGrupoInteres { get; set; }
        public byte? idSeguimientoProgramasIntervencionRiesgo { get; set; }
        public List<byte> idMotivoConsulta { get; set; }
        public List<byte> idMotivoContacto { get; set; }
        public string numAutorizacionPurisu { get; set; }
        public byte? idGruposFocales { get; set; }
        public byte? idEje { get; set; }
        public short? idUnidad { get; set; }
        public short? idModulo { get; set; }
        public byte? idEje1 { get; set; }
        public short? idUnidad1 { get; set; }
        public short? idModulo1 { get; set; }
        public List<byte> idPiezasInformativas { get; set; }
        public string firmaPurisu { get; set; }
    }
}