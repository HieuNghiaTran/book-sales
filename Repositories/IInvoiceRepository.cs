using System.Data;

namespace Book_Manager.Repositories
{
    public interface IInvoiceRepository
    {
        void AddDetailInvoice( string bookName, int quantity, int price);
        void AddInvoice(int total, int discount);
        DataSet GetAllInvoice();
        DataSet GetDetailInvoice(string id_invoice);
    }
}