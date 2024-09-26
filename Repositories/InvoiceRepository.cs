using Book_Manager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public long invoiceId { get; set; }   
        public InvoiceRepository() { this.invoiceId = 0; }


        public void AddDetailInvoice(string bookName, int quantity, int price)
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO invoice_details (id_invoice, book_name, quantity, price, total_price) VALUES (@id_invoice, @book_name, @quantity, @price, @total_price)", Database.con))
            {
                cmd.Parameters.AddWithValue("@id_invoice", this.invoiceId);
                cmd.Parameters.AddWithValue("@book_name", bookName);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@total_price",(quantity*price).ToString());
                cmd.ExecuteNonQuery();
           

            }
            
        }

        public void AddInvoice(int total, int discount)
        {
          
            try
            {
                DateTime tm = DateTime.Now;
                string time = tm.ToString("yyyy-MM-dd HH:mm:ss");
                if (Database.con.State == System.Data.ConnectionState.Closed)
                {
                    Database.Open();
                }
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO invoice (createdAt, total_amount, discount_amount) VALUES (@date, @total, @discount)", Database.con))
                {
                    cmd.Parameters.AddWithValue("@date", time);
                    cmd.Parameters.AddWithValue("@total", total.ToString());
                    cmd.Parameters.AddWithValue("@discount", discount.ToString());
                    cmd.ExecuteNonQuery();
                    invoiceId = cmd.LastInsertedId;
          
                }

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message.ToString());


            }
        }

        public DataSet GetAllInvoice()
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM invoice", Database.con))
                {
                    dataAdapter.Fill(ds, "data");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return ds;
        }

        public DataSet GetDetailInvoice(string id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM invoice_details where id_invoice= \'" + id + "\'", Database.con))
                {
                    dataAdapter.Fill(ds, "data");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }

            return ds;
        }


    }
}
