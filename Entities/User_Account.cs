using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final_APP.Entities
{
    public class User_Account
    {
        [StringLength(10)]
        public string MaNguoiDung { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(30)]
        public string TenDangNhap { get; set; }
        [Required]
        [StringLength(30)]
        public string MatKhau { get; set; }

        public bool? Quyen { get; set; }
    }
}