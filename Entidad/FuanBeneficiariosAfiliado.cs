//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coomuce.DirectorServicios.Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class FuanBeneficiariosAfiliado
    {
        public int idFuanBeneficiariosAfiliado { get; set; }
        public int idFuanAfiliado { get; set; }
        public string primerApellidoFuanBeneficiariosAfiliado { get; set; }
        public string segundoApellidoFuanBeneficiariosAfiliado { get; set; }
        public string primerNombreFuanBeneficiariosAfiliado { get; set; }
        public string segundoNombreFuanBeneficiariosAfiliado { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string identificacionFuanBeneficiariosAfiliado { get; set; }
        public byte idTipoSexo { get; set; }
        public Nullable<System.DateTime> fechaNacimientoFuanBeneficiariosAfiliado { get; set; }
        public byte idTipoParentesco { get; set; }
        public byte idTipoEtnia { get; set; }
        public Nullable<byte> idTipoDiscapacidad { get; set; }
        public Nullable<byte> idCondicionDiscapacidad { get; set; }
        public short idCiudad { get; set; }
        public byte idTipoZona { get; set; }
        public string telefonoFuanBeneficiariosAfiliado { get; set; }
        public Nullable<decimal> upcFuanBeneficiariosAfiliado { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        public virtual FuanAfiliado FuanAfiliado { get; set; }
        public virtual CondicionDiscapacidad CondicionDiscapacidad { get; set; }
        public virtual TipoDiscapacidad TipoDiscapacidad { get; set; }
        public virtual TipoEtnia TipoEtnia { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
        public virtual TipoParentesco TipoParentesco { get; set; }
        public virtual TipoSexo TipoSexo { get; set; }
        public virtual TipoZona TipoZona { get; set; }
    }
}
