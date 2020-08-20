using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace NetwrixTest.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base ("myConnection")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}