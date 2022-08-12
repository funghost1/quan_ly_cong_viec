namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHLAMVIEC")]
    public partial class LICHLAMVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LICHLAMVIEC()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        public decimal ID_LICH_LAM_VIEC { get; set; }

        public DateTime NGAY_BAT_DAU { get; set; }

        public DateTime GIO_BAT_DAU { get; set; }

        public DateTime NGAY_KET_THUC { get; set; }

        public DateTime GIO_KET_THUC { get; set; }

        [Required]
        [StringLength(200)]
        public string NOI_DUNG { get; set; }

        [StringLength(300)]
        public string THANH_PHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
