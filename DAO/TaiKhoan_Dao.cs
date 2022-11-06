using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_APP.Entities;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
namespace Final_APP.DAO
{
    public class TaiKhoan_Dao
    {
        DVMB db;
        public TaiKhoan_Dao()
        {
            db = new DVMB();
        }
            public int Login(string tendangnhap, string matkhau, bool Quyen )
        {
            var result = db.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == tendangnhap);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (Quyen == true)
                {
                        {
                        if (result.MatKhau == matkhau)
                            return 1;
                        else
                            return -2;
                        }
                  
                }
                else
                {
                    
                    {
                        if (result.MatKhau == matkhau)
                            return 1;
                        else
                            return -2;
                    }
                }
            }
        }

    }
}