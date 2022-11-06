namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            XuatHoaDons = new HashSet<XuatHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        public decimal? ThanhTien { get; set; }

        [StringLength(10)]
        public string MaPhieuDatVe { get; set; }

        [StringLength(10)]
        public string NgayXuatDon { get; set; }

        [StringLength(10)]
        public string MaHinhThucTT { get; set; }

        [StringLength(10)]
        public string MaKhuyenMai { get; set; }

        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }

        public virtual PhieuDatVe PhieuDatVe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XuatHoaDon> XuatHoaDons { get; set; }
    }
}
