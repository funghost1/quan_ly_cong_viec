namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIVANBAN")]
    public partial class LOAIVANBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIVANBAN()
        {
            VANBANs = new HashSet<VANBAN>();
        }

        [Key]
        public decimal ID_LOAI_VAN_BAN { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_LOAI_VAN_BAN { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_LOAI_VAN_BAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VANBAN> VANBANs { get; set; }
    }
}
