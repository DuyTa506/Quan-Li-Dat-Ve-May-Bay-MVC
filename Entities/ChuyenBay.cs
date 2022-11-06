namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenBay")]
    public partial class ChuyenBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenBay()
        {
            Ves = new HashSet<Ve>();
        }

        [Key]
        [StringLength(10)]
        public string MaChuyenBay { get; set; }

        public TimeSpan? TGbay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBay { get; set; }

        public TimeSpan? GioBay { get; set; }

        [StringLength(10)]
        public string LoaiMayBay { get; set; }

        public decimal? Gia { get; set; }

        public double? SaleTreEm { get; set; }

        public double? SaleEmBe { get; set; }

        [StringLength(10)]
        public string MaChangBay { get; set; }

        public virtual ChangBay ChangBay { get; set; }

        public virtual MayBay MayBay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ves { get; set; }
    }
}
