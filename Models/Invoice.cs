using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NetwrixTest.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [MaxLength(10)]
        public string Ref { get; set; }
        public DateTime InvoiceDate { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        [Required]
        [Range(0.0, Double.MaxValue)]
        public decimal Value { get; set; }
    }
}