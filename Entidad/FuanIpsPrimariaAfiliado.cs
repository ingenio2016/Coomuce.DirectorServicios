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
    
    public partial class FuanIpsPrimariaAfiliado
    {
        public int idFuanIpsPrimariaAfiliado { get; set; }
        public int idFuanAfiliado { get; set; }
        public string tipoFuanIpsPrimariaAfiliado { get; set; }
        public string nombreFuanIpsPrimariaAfiliado { get; set; }
        public string codigoFuanIpsPrimariaAfiliado { get; set; }
    
        public virtual FuanAfiliado FuanAfiliado { get; set; }
    }
}
