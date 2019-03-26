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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void QuanLyLop_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLyHeThong qlht = new QuanLyHeThong();
            qlht.Show();
            this.Hide();
        }
    }
}
