using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetwrixTest.Models
{
    public class HomeCustomer { 
        //if I was not using entity framework to create the links between the databases and application the home model would have inherited from Customer instead. I did not do this because I did not want to change the database columns.
        public Customer Customer { get; set; }
        public List<Invoice> PaidInvoices { get; set; }
        public List<Invoice> OutstandingInvoices { get; set; }
        public Invoice MostRecentInvoice { get; set; }
        public int OutstandingNum { get; set; }
        public decimal OutstandingValue { get; set; }

        public decimal PaidTotal { get; set; }
    }
}