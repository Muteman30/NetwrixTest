using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetwrixTest.Models
{
    public class HomeCustomer { 
        public Customer Customer { get; set; }
        public List<Invoice> PaidInvoices { get; set; }
        public List<Invoice> OutstandingInvoices { get; set; }
        public Invoice MostRecentInvoice { get; set; }
        public int OutstandingNum { get; set; }
        public decimal OutstandingValue { get; set; }

        public decimal PaidTotal { get; set; }
    }
}