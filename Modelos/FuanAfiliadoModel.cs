using System;

namespace Coomuce.DirectorServicios.Modelos
{
    public class FuanAfiliadoModel
    {
        public int idFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public DateTime fechaNacimientoFuanAfiliado { get; set; }
        public int edadFuanAfiliado { get { return DateTime.Today.AddTicks(-this.fechaNacimientoFuanAfiliado.Ticks).Year - 1; } }
        public byte? idDepartamento { get; set; }
        public string compDepartamento { get; set; }
        public short? idCiudad { get; set; }
        public string compCiudad { get; set; }
        public decimal? puntajeSisbenFuanAfiliado { get; set; }
        public string direccionFuanAfiliado { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string celularFuanAfiliado { get; set; }
        public string emailFuanAfiliado { get; set; }
        public string nombreTipoEtnia { get; set; }
        public string nombreTipoZona { get; set; }
        public byte idTipoSexo { get; set; }
        public string nombreTipoSexo { get; set; }
        public string pensionFuanAfiliado { get; set; }
        public string numCarnetFuanAfiliado { get; set; }
        public DateTime? fechaUltFicha { get; set; }
        public DateTime? fechaUltHistoria { get; set; }
    }
}