//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfConstractions.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Installation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Installation()
        {
            this.GUPassports = new HashSet<GUPassport>();
        }
    
        public System.Guid ID { get; set; }
        public byte[] tsc { get; set; }
        public System.DateTimeOffset upserted { get; set; }
        public System.Guid Persons_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GUPassport> GUPassports { get; set; }
    }
}