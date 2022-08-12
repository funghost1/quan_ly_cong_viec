namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FILEDINHKEM")]
    public partial class FILEDINHKEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FILEDINHKEM()
        {
            CONGVIECs = new HashSet<CONGVIEC>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID_TAP_TIN { get; set; }

        public decimal ID_VAN_BAN { get; set; }

        [Required]
        [StringLength(10)]
        public string KIEU_TAP_TIN { get; set; }

        [Required]
        [StringLength(30)]
        public string MO_TA { get; set; }

        [Required]
        [StringLength(20)]
        public string TEN_TAP_TIN { get; set; }

        [Required]
        [StringLength(100)]
        public string DUONG_DAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGVIEC> CONGVIECs { get; set; }

        public virtual VANBAN VANBAN { get; set; }
    }
}
