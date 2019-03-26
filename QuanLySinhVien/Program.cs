using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    static class Program
    {
        public static Thread th;
        public static Thread th1;

        [STAThread]
        static void Main()
        {
            th = new Thread(new ThreadStart(openform));
            th1 = new Thread(new ThreadStart(openform1));
            th1.Start();

        }

        static void openform()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLyDiem());
        }
        static void openform1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
