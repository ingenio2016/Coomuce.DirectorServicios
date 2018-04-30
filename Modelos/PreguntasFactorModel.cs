namespace Coomuce.DirectorServicios.Modelos
{
    public class PreguntasFactorModel
    {
        public short idPregunta { get; set; }
        public string factor { get; set; }
        public string subfactor { get; set; }
        public string codigoPregunta { get; set; }
        public string descripcionPregunta { get; set; }
        public bool respuestaSiPregunta { get; set; }
        public bool respuestaNoPregunta { get; set; }
    }
}