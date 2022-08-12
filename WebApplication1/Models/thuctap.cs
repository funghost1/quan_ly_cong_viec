namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class thuctap : DbContext
    {
        public thuctap()
            : base("name=thuctap")
        {
        }

        public virtual DbSet<BUTPHE> BUTPHEs { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANGs { get; set; }
        public virtual DbSet<CONGVIEC> CONGVIECs { get; set; }
        public virtual DbSet<DONVI> DONVIs { get; set; }
        public virtual DbSet<DOQUANTRONG> DOQUANTRONGs { get; set; }
        public virtual DbSet<FILEDINHKEM> FILEDINHKEMs { get; set; }
        public virtual DbSet<LICHLAMVIEC> LICHLAMVIECs { get; set; }
        public virtual DbSet<LINHVUC> LINHVUCs { get; set; }
        public virtual DbSet<LOAIVANBAN> LOAIVANBANs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NOI_PHAT_HANH> NOI_PHAT_HANH { get; set; }
        public virtual DbSet<TRANGTHAICONGVIEC> TRANGTHAICONGVIECs { get; set; }
        public virtual DbSet<VAITRO> VAITROes { get; set; }
        public virtual DbSet<VANBAN> VANBANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BUTPHE>()
                .Property(e => e.ID_BUT_PHE)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BUTPHE>()
                .Property(e => e.ID_VAN_BAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BUTPHE>()
                .Property(e => e.NOI_DUNG_BUT_PHE)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCNANG>()
                .Property(e => e.ID_CHUC_NANG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CHUCNANG>()
                .Property(e => e.TEN_CHUC_NANG)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCNANG>()
                .HasMany(e => e.VAITROes)
                .WithMany(e => e.CHUCNANGs)
                .Map(m => m.ToTable("QUYEN").MapLeftKey("ID_CHUC_NANG").MapRightKey("ID_VAI_TRO"));

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_CONG_VIEC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_DO_QUAN_TRONG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_TAP_TIN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_NHAN_VIEN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_LINH_VUC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_TRANG_THAI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_NGUOI_GUI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.ID_NGUOI_NHAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.TIEU_DE)
                .IsUnicode(false);

            modelBuilder.Entity<CONGVIEC>()
                .Property(e => e.NOI_DUNG)
                .IsUnicode(false);

            modelBuilder.Entity<DONVI>()
                .Property(e => e.ID_DON_VI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DONVI>()
                .Property(e => e.MA_DON_VI)
                .IsUnicode(false);

            modelBuilder.Entity<DONVI>()
                .Property(e => e.TEN_DON_VI)
                .IsUnicode(false);

            modelBuilder.Entity<DONVI>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.DONVI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOQUANTRONG>()
                .Property(e => e.ID_DO_QUAN_TRONG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DOQUANTRONG>()
                .Property(e => e.TEN_DO_QUAN_TRONG)
                .IsUnicode(false);

            modelBuilder.Entity<DOQUANTRONG>()
                .HasMany(e => e.CONGVIECs)
                .WithRequired(e => e.DOQUANTRONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FILEDINHKEM>()
                .Property(e => e.ID_TAP_TIN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FILEDINHKEM>()
                .Property(e => e.ID_VAN_BAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FILEDINHKEM>()
                .Property(e => e.KIEU_TAP_TIN)
                .IsUnicode(false);

            modelBuilder.Entity<FILEDINHKEM>()
                .Property(e => e.MO_TA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FILEDINHKEM>()
                .Property(e => e.TEN_TAP_TIN)
                .IsUnicode(false);

            modelBuilder.Entity<FILEDINHKEM>()
                .Property(e => e.DUONG_DAN)
                .IsUnicode(false);

            modelBuilder.Entity<FILEDINHKEM>()
                .HasMany(e => e.CONGVIECs)
                .WithRequired(e => e.FILEDINHKEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LICHLAMVIEC>()
                .Property(e => e.ID_LICH_LAM_VIEC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LICHLAMVIEC>()
                .Property(e => e.NOI_DUNG)
                .IsUnicode(false);

            modelBuilder.Entity<LICHLAMVIEC>()
                .Property(e => e.THANH_PHAN)
                .IsUnicode(false);

            modelBuilder.Entity<LICHLAMVIEC>()
                .HasMany(e => e.NHANVIENs)
                .WithMany(e => e.LICHLAMVIECs)
                .Map(m => m.ToTable("THANH_PHAN_THAM_DU").MapLeftKey("ID_LICH_LAM_VIEC").MapRightKey("ID_NHAN_VIEN"));

            modelBuilder.Entity<LINHVUC>()
                .Property(e => e.ID_LINH_VUC)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LINHVUC>()
                .Property(e => e.MA_LINH_VUC)
                .IsUnicode(false);

            modelBuilder.Entity<LINHVUC>()
                .Property(e => e.TEN_LINH_VUC)
                .IsUnicode(false);

            modelBuilder.Entity<LINHVUC>()
                .HasMany(e => e.CONGVIECs)
                .WithRequired(e => e.LINHVUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIVANBAN>()
                .Property(e => e.ID_LOAI_VAN_BAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LOAIVANBAN>()
                .Property(e => e.MA_LOAI_VAN_BAN)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIVANBAN>()
                .Property(e => e.TEN_LOAI_VAN_BAN)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIVANBAN>()
                .HasMany(e => e.VANBANs)
                .WithRequired(e => e.LOAIVANBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.ID_NHAN_VIEN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.ID_DON_VI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.ID_VAI_TRO)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MA_NHAN_VIEN)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.HO_TEN)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .HasPrecision(10, 0);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.DIA_CHI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CONGVIECs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.VANBANs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BUTPHEs)
                .WithMany(e => e.NHANVIENs)
                .Map(m => m.ToTable("NHANVIENBUTPHE").MapLeftKey("ID_NHAN_VIEN").MapRightKey("ID_BUT_PHE"));

            modelBuilder.Entity<NOI_PHAT_HANH>()
                .Property(e => e.ID_NOI_PHAT_HANH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NOI_PHAT_HANH>()
                .Property(e => e.TEN_NOI_PHAT_HANH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOI_PHAT_HANH>()
                .HasMany(e => e.VANBANs)
                .WithRequired(e => e.NOI_PHAT_HANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANGTHAICONGVIEC>()
                .Property(e => e.ID_TRANG_THAI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TRANGTHAICONGVIEC>()
                .Property(e => e.TEN_TRANG_THAI)
                .IsUnicode(false);

            modelBuilder.Entity<TRANGTHAICONGVIEC>()
                .HasMany(e => e.CONGVIECs)
                .WithRequired(e => e.TRANGTHAICONGVIEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VAITRO>()
                .Property(e => e.ID_VAI_TRO)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VAITRO>()
                .Property(e => e.TEN_VAI_TRO)
                .IsUnicode(false);

            modelBuilder.Entity<VAITRO>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.VAITRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.ID_VAN_BAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.ID_NOI_PHAT_HANH)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.ID_NHAN_VIEN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.ID_LOAI_VAN_BAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.SO_VAN_BAN)
                .IsUnicode(false);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.TRICH_YEU)
                .IsUnicode(false);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.NGUOI_KY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VANBAN>()
                .Property(e => e.TRANG_THAI_XU_LY)
                .IsUnicode(false);

            modelBuilder.Entity<VANBAN>()
                .HasMany(e => e.BUTPHEs)
                .WithRequired(e => e.VANBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VANBAN>()
                .HasMany(e => e.FILEDINHKEMs)
                .WithRequired(e => e.VANBAN)
                .WillCascadeOnDelete(false);
        }
    }
}
