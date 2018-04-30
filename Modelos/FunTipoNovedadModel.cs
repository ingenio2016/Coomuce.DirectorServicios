using System.Collections.Generic;

namespace Coomuce.DirectorServicios.Modelos
{
    public class FunTipoNovedadModel
    {
        public int idFuan { get; set; }
        public byte idTipoNovedad { get; set; }
        public string compTipoNovedad { get; set; }
        public string tipoValorCampoTipoNovedad { get; set; }
        public string valorCampoTipoNovedad { get; set; }
        public bool selFuanTipoNovedad { get; set; }
        public string valorFuanTipoNovedad { get; set; }
    }
}