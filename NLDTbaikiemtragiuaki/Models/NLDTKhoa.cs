//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLDTbaikiemtragiuaki.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NLDTKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NLDTKhoa()
        {
            this.NLDTSinhVien = new HashSet<NLDTSinhVien>();
        }
    
        public string NLDTMaKH { get; set; }
        public string NLDTTenKH { get; set; }
        public Nullable<bool> NLDTTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NLDTSinhVien> NLDTSinhVien { get; set; }
    }
}
