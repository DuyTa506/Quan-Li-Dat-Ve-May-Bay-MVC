namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ve")]
    public partial class Ve
    {
        [Key]
        [StringLength(10)]
        public string MaVe { get; set; }

        [StringLength(50)]
        public string TenLoaiVe { get; set; }

        public int? SoGhe { get; set; }

        [StringLength(50)]
        public string KhoangGhe { get; set; }

        [StringLength(10)]
        public string MaPhieuDatVe { get; set; }

        [StringLength(10)]
        public string MaLoaiVe { get; set; }

        [StringLength(10)]
        public string MaChuyenBay { get; set; }

        public virtual ChuyenBay ChuyenBay { get; set; }

        public virtual PhieuDatVe PhieuDatVe { get; set; }
    }
}
