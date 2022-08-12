namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOI_PHAT_HANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOI_PHAT_HANH()
        {
            VANBANs = new HashSet<VANBAN>();
        }

        [Key]
        public decimal ID_NOI_PHAT_HANH { get; set; }

        [Required]
        [StringLength(50)]
        public string TEN_NOI_PHAT_HANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VANBAN> VANBANs { get; set; }
    }
}
