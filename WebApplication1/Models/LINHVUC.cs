namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LINHVUC")]
    public partial class LINHVUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LINHVUC()
        {
            CONGVIECs = new HashSet<CONGVIEC>();
        }

        [Key]
        public decimal ID_LINH_VUC { get; set; }

        [Required]
        [StringLength(10)]
        public string MA_LINH_VUC { get; set; }

        [Required]
        [StringLength(20)]
        public string TEN_LINH_VUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGVIEC> CONGVIECs { get; set; }
    }
}
