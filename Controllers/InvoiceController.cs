using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetwrixTest.Models;
using NetwrixTest.ViewModels;
using System.Data.Entity;

namespace NetwrixTest.Controllers
{
    public class InvoiceController : Controller
    {
        private ApplicationDbContext _context;
        public InvoiceController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Invoice
        public ActionResult Index()
        {
            var vm = new AllInvoices
            {
                Invoices = _context.Invoices.Include(i => i.Customer).ToList()
            };
            return View(vm);
        }
    }
}