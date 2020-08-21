using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetwrixTest.Models;

namespace NetwrixTest.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}