using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NetwrixTest.Models;
using NetwrixTest.ViewModels;

namespace NetwrixTest.Controllers
{
    public class HomeController : Controller
    {   
        //connection to the database
        ApplicationDbContext _context;
        public HomeController() {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            //This is the view model to include all of the details requested. 
            //If I had more time I would recommend the details to be loaded via a Web API, shortening loading time and freeing up the users ui
            var vm = new HomeTestViewModel {
                PaidInvoicesNumber = _context.Invoices.Where(i => i.IsPaid).Count(),
                PaidInvoicesValue = _context.Invoices.Where(i => i.IsPaid).AsEnumerable().Aggregate(0M, (acc, inv) =>acc+inv.Value),
                Customers = _context.Customers.Select(c => new HomeCustomer{
                    Customer = c,
                    PaidInvoices = _context.Invoices.OrderBy(i => i.InvoiceDate).Where(i => i.CustomerId == c.Id && c.Id == i.CustomerId).ToList(),
                    OutstandingInvoices = _context.Invoices.Where(i => !i.IsPaid && c.Id == i.CustomerId).ToList(),
                    MostRecentInvoice = _context.Invoices.OrderBy(i => i.InvoiceDate).FirstOrDefault(i => i.CustomerId == c.Id),
                    OutstandingNum = _context.Invoices.Where(i => !i.IsPaid && c.Id == i.CustomerId).Count(),
                }).ToList()

            };
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}