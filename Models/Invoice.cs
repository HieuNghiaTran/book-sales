using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Manager.Models
{
    internal class Invoice
    {

        public DateTime createAt { get; set; }
        public decimal total_amount { get; set; }
        public decimal discount_amount { get; set; }


        public Invoice()
        {

            this.createAt = DateTime.Now;
            this.total_amount = 0;
            this.discount_amount = 0;


        }

    }
}
