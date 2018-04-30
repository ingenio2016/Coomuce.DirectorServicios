using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Web;

namespace Coomuce.DirectorServicios.Modelos
{
    [XmlRootAttribute("ReporteNovedad", Namespace = "http://www.cpandl.com", IsNullable = false)]
    public class ReporteNovedadModel
    {
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string compTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public byte idTipoSexo { get; set; }
        public string compTipoSexo { get; set; }
        public string fechaNacimientoFuanAfiliado { get; set; }
        public string epsAnteriorFuanAfiliado { get; set; }
        public byte idMotivoTraslado { get; set; }
        public string compMotivoTraslado { get; set; }
        public string pensionFuanAfiliado { get; set; }
        public byte idDepartamento { get; set; }
        public string compDepartamento { get; set; }
        public short? idCiudad { get; set; }
        public string compCiudad { get; set; }
        public string firmaNovedad { get; set; }
    }
}