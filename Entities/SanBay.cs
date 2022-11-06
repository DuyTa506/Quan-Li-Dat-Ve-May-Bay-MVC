namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanBay")]
    public partial class SanBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanBay()
        {
            ChangBays = new HashSet<ChangBay>();
            ChangBays1 = new HashSet<ChangBay>();
        }

        [Key]
        [StringLength(10)]
        public string MaSanBay { get; set; }

        [StringLength(50)]
        public string TenSanBay { get; set; }

        [StringLength(50)]
        public string ViTri { get; set; }

        [StringLength(50)]
        public string KhuVuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangBay> ChangBays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangBay> ChangBays1 { get; set; }
    }
}
