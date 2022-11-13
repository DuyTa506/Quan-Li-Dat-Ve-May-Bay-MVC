using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_APP.Entities
{
    public class LichSuDatVe
    {
        
        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

         [Column(TypeName = "date")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yy}")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime? NgayDat { get; set; }

        public decimal? ThanhTien { get; set; }
    }
}