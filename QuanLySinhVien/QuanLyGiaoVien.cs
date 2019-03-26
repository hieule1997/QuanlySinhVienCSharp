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
    public partial class QuanLyGiaoVien : Form
    {
        public QuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void QuanLyGiaoVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLyHeThong qlht = new QuanLyHeThong();
            qlht.Show();
            this.Hide();
        }
    }
}
