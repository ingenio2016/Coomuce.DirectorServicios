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
    
    public partial class CicloVital
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CicloVital()
        {
            this.CicloVitalPreguntasSubFactorRiesgo = new HashSet<CicloVitalPreguntasSubFactorRiesgo>();
        }
    
        public byte idCicloVital { get; set; }
        public byte edadMinCicloVital { get; set; }
        public byte edadMaxCicloVital { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CicloVitalPreguntasSubFactorRiesgo> CicloVitalPreguntasSubFactorRiesgo { get; set; }
    }
}
