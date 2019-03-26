using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using System.Reflection;
using iTextSharp.text.pdf;

namespace QuanLySinhVien
{
    public partial class LapDanhSachGiaoVienDay : Form
    {
        public LapDanhSachGiaoVienDay()
        {
            InitializeComponent();
        }

        private void LapDanhSachGiaoVienDay_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLyHeThong qlht = new QuanLyHeThong();
            qlht.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PdfPTable pdfPTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 30;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(240,240,240);
                pdfPTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(cell.Value.ToString());
                }
            }


            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\Hieu Koi\\Desktop\\xuatpfile.pdf", FileMode.Create));
            doc.Open();
            Paragraph par = new Paragraph("this is my paragreap");
            doc.Add(par);
            doc.Add(pdfPTable);
            doc.Close();
            MessageBox.Show("bạn đã xuất file pdf thành công !");
        }

        
    }
}
