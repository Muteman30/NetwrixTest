using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace NetwrixTest.Models
{
    public class ApplicationDbContext : DbContext
    {
        //the connection string is noted in the web.config file
        public ApplicationDbContext() : base ("myConnection")
        {

        }
        //DB Sets of related data.
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}