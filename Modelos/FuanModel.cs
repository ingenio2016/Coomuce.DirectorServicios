using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.DirectorServicios.Modelos
{
    public class FuanModel
    {
        public int idFuan { get; set; }
        public byte idTipoTramite { get; set; }
        public byte idTipoAfiliacion { get; set; }
        public byte idTipoRegimen { get; set; }
        public byte idTipoAfiliado { get; set; }
        public byte idTipoCotizante { get; set; }
        public string codigoCotizanteFuan { get; set; }
        public int idUsuario { get; set; }
    }
}