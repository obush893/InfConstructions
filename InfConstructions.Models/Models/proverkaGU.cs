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
    
    public partial class proverkaGU
    {
        public string Num { get; set; }
        public string Okrug { get; set; }
        public string Raion { get; set; }
        public string Street { get; set; }
        public string Dom { get; set; }
        public string ErrorAdress { get; set; }
        public string Fakt { get; set; }
        public Nullable<bool> Maket { get; set; }
        public Nullable<bool> Passport { get; set; }
        public string Prim { get; set; }
        public Nullable<bool> Checking { get; set; }
        public int ID { get; set; }
        public string Plash { get; set; }
        public byte[] ts { get; set; }
        public Nullable<System.DateTimeOffset> updated { get; set; }
        public Nullable<System.Guid> newPassportID { get; set; }
    }
}
