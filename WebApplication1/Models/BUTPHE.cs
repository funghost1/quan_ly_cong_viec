namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BUTPHE")]
    public partial class BUTPHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BUTPHE()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        public decimal ID_BUT_PHE { get; set; }

        public decimal ID_VAN_BAN { get; set; }

        [StringLength(100)]
        public string NOI_DUNG_BUT_PHE { get; set; }

        public DateTime? THOI_GIAN_BD { get; set; }

        public DateTime? THOI_GIAN_KT { get; set; }

        public virtual VANBAN VANBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
