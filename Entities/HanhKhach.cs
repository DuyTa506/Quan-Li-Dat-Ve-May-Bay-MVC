namespace Final_APP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HanhKhach")]
    public partial class HanhKhach
    {
        [Key]
        [StringLength(10)]
        public string MaHanhKhach { get; set; }

        [StringLength(50)]
        public string LoaiHanhKhach { get; set; }

        [StringLength(50)]
        public string Ho { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string DanhXung { get; set; }

        public double? HanhLy { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
