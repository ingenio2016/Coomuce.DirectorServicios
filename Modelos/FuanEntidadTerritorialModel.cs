using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.DirectorServicios.Modelos
{
    public class FuanEntidadTerritorialModel
    {
        public int idFuan { get; set; }
        public short idCiudad { get; set; }
        public string numFichaSisbenFuanEntidadTerritorial { get; set; }
        public string puntajeSisbenFuanEntidadTerritorial { get; set; }
        public string nivelSisbenFuanEntidadTerritorial { get; set; }
        public string fechaRadicacionFuanEntidadTerritorial { get; set; }
        public string fechaValidacionFuanEntidadTerritorial { get; set; }
        public int idUsuario { get; set; }
        public string observacionFuanEntidadTerritorial { get; set; }
    }
}