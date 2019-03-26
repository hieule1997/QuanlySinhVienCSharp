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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuanLyHeThong qlht = new QuanLyHeThong();
            qlht.Show();
            this.Hide();

        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
