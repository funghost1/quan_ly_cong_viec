namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGVIEC")]
    public partial class CONGVIEC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_CONG_VIEC { get; set; }

        [Display(Name = "Độ Quann Trọng")]
        public decimal ID_DO_QUAN_TRONG { get; set; }

        [Display(Name = "File Đính Kèm")]
        public decimal ID_TAP_TIN { get; set; }

        [Display(Name = "Họ Tên Nhân Viên Gửi")]
        public decimal ID_NHAN_VIEN { get; set; }

        [Display(Name = "Lĩnh Vực")]
        public decimal ID_LINH_VUC { get; set; }

        [Display(Name = "Trạng thái Công Việc")]
        public decimal ID_TRANG_THAI { get; set; }

        [Display(Name = "Mã Nhân Viên Gửi")]
        public decimal ID_NGUOI_GUI { get; set; }

        [Display(Name = "Mã Nhân Viên Nhận")]
        public decimal ID_NGUOI_NHAN { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Tiêu Đề")]
        public string TIEU_DE { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày Hết Hạn")]
        public DateTime NGAY_HET_HAN { get; set; }
        [Display(Name = "Ngày Gửi")]
        public DateTime NGAY_GUI { get; set; }
        [Display(Name = "Tỷ Lệ Hoàn Thành")]
        public int TY_LE_HOAN_THANH { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Nội Dung")]
        public string NOI_DUNG { get; set; }

        public virtual TRANGTHAICONGVIEC TRANGTHAICONGVIEC { get; set; }

        public virtual LINHVUC LINHVUC { get; set; }

        public virtual FILEDINHKEM FILEDINHKEM { get; set; }

        public virtual DOQUANTRONG DOQUANTRONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
