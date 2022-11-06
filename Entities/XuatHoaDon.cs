namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuatHoaDon")]
    public partial class XuatHoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaXuat { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayXuat { get; set; }

        [StringLength(50)]
        public string NoiXuat { get; set; }

        [StringLength(10)]
        public string MaHoaDon { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
