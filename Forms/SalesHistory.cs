using Book_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager.Forms
{
    public partial class SalesHistory : Form
    {
        InvoiceRepository invoiceRepository;


        public SalesHistory()
        {
            InitializeComponent();
            invoiceRepository = new InvoiceRepository();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {


            DataSet ds = invoiceRepository.GetAllInvoice();
            DataTable dt = ds.Tables["data"];
            dt.Columns["id_invoice"].ColumnName = "Mã hoá đơn";
            dt.Columns["createdAt"].ColumnName = "Ngày tạo";
            dt.Columns["total_amount"].ColumnName = "Tổng giá trị (đã gg)";
            dt.Columns["discount_amount"].ColumnName = "Giảm giá";

           
            dgvHistory.DataSource = dt;

            dgvHistory.Columns["Tổng giá trị (đã gg)"].DefaultCellStyle.Format = "C2";
            dgvHistory.Columns["Giảm giá"].DefaultCellStyle.Format = "C2";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int selectedInvoice = (int)dgvHistory.Rows[e.RowIndex].Cells[1].Value;
 
                Detail_Invoice detail = new Detail_Invoice(selectedInvoice.ToString());
                detail.ShowDialog();


                
            }
        }
    }
}
