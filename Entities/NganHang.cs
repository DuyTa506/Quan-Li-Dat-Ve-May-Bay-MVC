namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NganHang")]
    public partial class NganHang
    {
        [Key]
        [StringLength(10)]
        public string MaNganHang { get; set; }

        [StringLength(50)]
        public string TenNganHang { get; set; }

        [StringLength(10)]
        public string MaHinhThucTT { get; set; }

        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }
    }
}
