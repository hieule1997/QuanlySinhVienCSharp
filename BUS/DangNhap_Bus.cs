using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap_Bus
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
        //Kiểm tra tài khoản
        public Boolean KTTK(string tk, string mk)
        {
            string sql = "Select * from CanBoGiaoVien where Taikhoan ='" + tk + "'"; // chuỗi truy vấn đưa ra bảng tài khoản và mật khẩu để check mật khẩu
            DataTable dt = new DataTable();
            dt = da.Getdatatable(sql);
            int ma = Soacc(tk); //trả về số tài khoản có tài khoản đã nhập ở text box trên

            if (ma == 0)
            {
                return false;

            }
            else
            {
                string kt = dt.Rows[0][5].ToString();// lấy mật khẩu ra
                kt = kt.Trim();
                if (Equals(kt, mk)) // so sánh mật khẩu với pass có trùng nhau hay không ?
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int LoaiTaiKhoan(string tk)
        {
            string sql = "Select top(1) Loaitaikhoan from CanBoGiaoVien where Taikhoan= '" + tk + "'";
            DataTable dt = new DataTable();
            dt = da.Getdatatable(sql);
            return Int32.Parse(dt.Rows[0][0].ToString());
        }
    }
}
