using Book_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager.Forms
{
    public partial class Detail_Invoice : Form
    {
        InvoiceRepository invoiceRepository;
        string id;
        public Detail_Invoice(string id)
        {
            invoiceRepository = new InvoiceRepository();
            this.id = id;
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detail_Invoice_Load(object sender, EventArgs e)
        {
            DataSet ds = invoiceRepository.GetDetailInvoice(id);
            DataTable dt = ds.Tables["data"];
            if (dt == null)
            {
                MessageBox.Show("No data found.");
                return;
            }

            dt.Columns.Remove("id");
            dt.Columns["id_invoice"].ColumnName = "Mã hoá đơn";
            dt.Columns["book_name"].ColumnName = "Tên Sách";
            dt.Columns["quantity"].ColumnName = "Số Lượng";
            dt.Columns["price"].ColumnName = "Giá Thành";
            dt.Columns["total_price"].ColumnName = "Tổng cộng";

            dgvDetailInvoice.DataSource = dt;
            dgvDetailInvoice.Columns["Giá Thành"].DefaultCellStyle.Format = "C2";
            dgvDetailInvoice.Columns["Tổng cộng"].DefaultCellStyle.Format = "C2";


            decimal totalSum = 0;
            if (dt.Columns.Contains("Tổng cộng"))
            {
                totalSum = Convert.ToDecimal(dt.Compute("SUM([Tổng cộng])", string.Empty));
            }
            lbtotal.Text = totalSum.ToString("C") + "đ";
            lbquantity.Text = (dgvDetailInvoice.RowCount - 1).ToString() + " Sản phẩm";




        }
    }
}
