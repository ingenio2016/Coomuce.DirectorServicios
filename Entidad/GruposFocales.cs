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
    
    public partial class GruposFocales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GruposFocales()
        {
            this.AsistenciaGeneral = new HashSet<AsistenciaGeneral>();
            this.Purisu = new HashSet<Purisu>();
        }
    
        public byte idGruposFocales { get; set; }
        public string codigoGruposFocales { get; set; }
        public string nombreGruposFocales { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsistenciaGeneral> AsistenciaGeneral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purisu> Purisu { get; set; }
    }
}
