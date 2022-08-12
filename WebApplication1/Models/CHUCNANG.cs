namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCNANG")]
    public partial class CHUCNANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCNANG()
        {
            VAITROes = new HashSet<VAITRO>();
        }

        [Key]
        public decimal ID_CHUC_NANG { get; set; }

        [Required]
        [StringLength(30)]
        public string TEN_CHUC_NANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VAITRO> VAITROes { get; set; }
    }
}
