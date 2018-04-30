namespace Coomuce.DirectorServicios.Modelos
{
    public class AsistenciaGeneralModel
    {
        public int idAsistenciaGeneral { get; set; }
        public string fechaAsistenciaGeneral { get; set; }
        public short idCiudad { get; set; }
        public byte idGruposFocales { get; set; }
        public string temaAsistenciaGeneral { get; set; }
        public short idModulo { get; set; }
        public string formadorAsistenciaGeneral { get; set; }
        public int idUsuario { get; set; }
    }
}