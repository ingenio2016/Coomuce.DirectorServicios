using System.Collections.Generic;

namespace Coomuce.DirectorServicios.Modelos
{
    public class DatosSeguridad
    {
        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string nombreUsuarioFormato { get; set; }
        public byte idRol { get; set; }
        public string nombreRol { get; set; }
        public byte tiempoInactividad { get; set; }
        public decimal? salarioMinimo { get; set; }
    }

    public class menu
    {
        public int idMenu { get; set; }
        public int? idPadreMenu { get; set; }
        public string text { get; set; }
        public string iconCls { get; set; }
        public string vista { get; set; }
        public string idDomVista { get; set; }
        public int orden { get; set; }
        public bool leaf { get; set; }
        public List<menu> children { get; set; }
    }

    public class obj
    {
        public int idMenu { get; set; }
        public int? idPadreMenu { get; set; }
        public string nomMenu { get; set; }
        public string iconoMenu { get; set; }
        public string idVista { get; set; }
        public string idDomVista { get; set; }
        public int ordenMenu { get; set; }
    }
}