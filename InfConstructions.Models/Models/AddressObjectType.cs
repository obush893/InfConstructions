//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNS.Models.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddressObjectType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AddressObjectType()
        {
            this.Objects = new HashSet<Object>();
        }
    
        public int LEVEL { get; set; }
        public string SCNAME { get; set; }
        public string SOCRNAME { get; set; }
        public string KOD_T_ST { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object> Objects { get; set; }
    }
}
