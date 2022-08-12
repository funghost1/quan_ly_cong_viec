namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VANBAN")]
    public partial class VANBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VANBAN()
        {
            BUTPHEs = new HashSet<BUTPHE>();
            FILEDINHKEMs = new HashSet<FILEDINHKEM>();
        }

        [Key]
        public decimal ID_VAN_BAN { get; set; }

        public decimal ID_NOI_PHAT_HANH { get; set; }

        public decimal ID_NHAN_VIEN { get; set; }

        public decimal ID_LOAI_VAN_BAN { get; set; }

        [Required]
        [StringLength(20)]
        public string SO_VAN_BAN { get; set; }

        [Required]
        [StringLength(50)]
        public string TRICH_YEU { get; set; }

        [Required]
        [StringLength(20)]
        public string NGUOI_KY { get; set; }

        public DateTime NGAY_KY { get; set; }

        [Required]
        [StringLength(2)]
        public string TRANG_THAI_XU_LY { get; set; }

        public DateTime? NGAY_GOI { get; set; }

        public DateTime? NGAY_NHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUTPHE> BUTPHEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILEDINHKEM> FILEDINHKEMs { get; set; }

        public virtual LOAIVANBAN LOAIVANBAN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NOI_PHAT_HANH NOI_PHAT_HANH { get; set; }
    }
}
