using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Canbogiaovien_DTO L = new Canbogiaovien_DTO();
        DangNhap_Bus LopB = new DangNhap_Bus();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttk.Text == "")
            {
                MessageBox.Show("Bạn cần nhập tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttk.Focus();
            }else if(txtmk.Text =="")
            {
                MessageBox.Show("Bạn cần nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtmk.Focus();
            }else
            {
                L.Taikhoan = txttk.Text;
                L.Matkhau = txtmk.Text;
                if (LopB.KTTK(L.Taikhoan, L.Matkhau))  // check pass and usedname
                {
                    if (LopB.LoaiTaiKhoan(L.Taikhoan) == 1)
                    {
                        try
                        {
                            //Form1.UsedName = textTK.Text;
                            this.Hide();
                            QuanLyDiem mt = new QuanLyDiem();
                            mt.Show();

                        }
                        catch
                        {
                            MessageBox.Show("Tài khoản không khả dụng ");
                        }
                    }
                    else
                    {
                            try
                            {
                                //Form1.UsedName = textTK.Text;
                                this.Hide();
                                QuanLyHeThong mt = new QuanLyHeThong();
                                mt.Show();

                            }
                            catch
                            {
                                MessageBox.Show("Tài khoản không khả dụng ");
                            }
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ vui lòng nhập lại");
                }

            }
        }
    }
}
