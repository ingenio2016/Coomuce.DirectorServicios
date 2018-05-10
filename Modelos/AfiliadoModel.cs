using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coomuce.DirectorServicios.Modelos
{
    public class AfiliadoModel
    {
        public int idFuanAfiliado { get; set; }
        public int idFuan { get; set; }
        public string tipoFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public byte idTipoSexo { get; set; }
        public string fechaNacimientoFuanAfiliado { get; set; }
        public byte idTipoEtnia { get; set; }
        public Nullable<byte> idTipoDiscapacidad { get; set; }
        public Nullable<byte> idCondicionDiscapacidad { get; set; }
        public string puntajeSisbenFuanAfiliado { get; set; }
        public string numCarnetFuanAfiliado { get; set; }
        public Nullable<byte> idGrupoPoblacional { get; set; }
        public string arlFuanAfiliado { get; set; }
        public string pensionFuanAfiliado { get; set; }
        public string ibcFuanAfiliado { get; set; }
        public string direccionFuanAfiliado { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string celularFuanAfiliado { get; set; }
        public string emailFuanAfiliado { get; set; }
        public Nullable<short> idCiudad { get; set; }
        public byte idTipoZona { get; set; }
        public string barrioFuanAfiliado { get; set; }
        public string primerApellidoConyugueFuanAfiliado { get; set; }
        public string segundoApellidoConyugueFuanAfiliado { get; set; }
        public string primerNombreConyugueFuanAfiliado { get; set; }
        public string segundoNombreConyugueFuanAfiliado { get; set; }
        public Nullable<byte> idTipoIdentificacionConyugue { get; set; }
        public string identificacionConyugueFuanAfiliado { get; set; }
        public Nullable<byte> idTipoSexoConyugue { get; set; }
        public string fechaNacimientoConyugueFuanAfiliado { get; set; }
        public Nullable<decimal> upcFuanAfiliado { get; set; }
    }
}