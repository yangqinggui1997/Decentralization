//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3A.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHOM_QUYEN_HAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHOM_QUYEN_HAN()
        {
            this.NHOM_NGUOI_DUNG = new HashSet<NHOM_NGUOI_DUNG>();
        }
    
        public string IdNQH { get; set; }
        public string TenNQH { get; set; }
        public string MoTa { get; set; }
        public string DanhmucTC { get; set; }
        public string QuyenDM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHOM_NGUOI_DUNG> NHOM_NGUOI_DUNG { get; set; }
    }
}