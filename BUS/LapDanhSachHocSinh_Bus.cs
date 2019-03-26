using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class LapDanhSachHocSinh_Bus
    {
        Data da = new Data();
        // đếm xem có bao nhiêu tài khoản có chuỗi đưa vào 
        public int Soacc(string tk)
        {
            string sql = "Select Count (*) from CanBoGiaoVien where Taikhoan= '" + tk + "'";
            DataTable dt = new DataTable();
            dt = da.Getdatatable(sql);
            return Int32.Parse(dt.Rows[0][0].ToString());
        }
    }
}
