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
    public partial class QuanLyHeThong : Form
    {
        public QuanLyHeThong()
        {
            InitializeComponent();
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySinhVien qlsv = new QuanLySinhVien();
            qlsv.Show();
            this.Hide();
        }

        private void quảnLýMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc qlsv = new QuanLyMonHoc();
            qlsv.Show();
            this.Hide();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyLop qlsv = new QuanLyLop();
            qlsv.Show();
            this.Hide();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyGiaoVien qlsv = new QuanLyGiaoVien();
            qlsv.Show();
            this.Hide();
        }

        private void phânCôngGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCongGiangDay qlsv = new PhanCongGiangDay();
            qlsv.Show();
            this.Hide();
        }

        private void lậpDanhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapDanhSachHocSinh qlsv = new LapDanhSachHocSinh();
            qlsv.Show();
            this.Hide();
        }

        private void lậpDanhSáchGiáoViênTheoLơpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LapDanhSachGiaoVienDay qlsv = new LapDanhSachGiaoVienDay();
            qlsv.Show();
            this.Hide();
        }

        private void QuanLyHeThong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
