using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetwrixTest.Models;
using NetwrixTest.ViewModels;

namespace NetwrixTest.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var vm = new AllCustomers
            {
                Customers = _context.Customers.ToList()
            };
            return View(vm);
        }

        public ActionResult Customer(int id)
        {
            Customer custinDB = _context.Customers.SingleOrDefault(c => c.Id == id);
           
            if (custinDB == null)
            {
                return HttpNotFound();
            }
            else
            {
                CustomerViewModel vm = new CustomerViewModel
                {
                    Customer = custinDB,
                    Invoices = _context.Invoices.Where(i => i.CustomerId == id).ToList()
                };
                return View(vm);
            }
            
        }
    }
}