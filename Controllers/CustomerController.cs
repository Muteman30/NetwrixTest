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
        //context to the the database
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            //will return all customers as a list. 
            var vm = new AllCustomers
            {
                Customers = _context.Customers.ToList()
            };
            return View(vm);
        }

        public ActionResult Customer(int id)
        {
            //the Customer page details all of the necessary details around a singular customer and their invoices.
            Customer custinDB = _context.Customers.SingleOrDefault(c => c.Id == id);
           //Error checking to make sure that the customer was found.
            if (custinDB == null)
            {
                return HttpNotFound();
            }
            else
            {
                //This is the customer view model passed to the view. Allows the invoices to be attached in a singular request.
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