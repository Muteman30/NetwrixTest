using NetwrixTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetwrixTest.ViewModels
{
    public class HomeTestViewModel
    {       
        public List<HomeCustomer> Customers { get; set; }
        public int PaidInvoicesNumber { get; set; }
        public decimal PaidInvoicesValue { get; set; }
    }
}