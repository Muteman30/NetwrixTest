using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NetwrixTest.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address1 { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address2 { get; set; }
        [Required]
        [MaxLength(100)]
        public string Postcode { get; set; }
        [Required]
        [MaxLength(15)]
        public string Telephone { get; set; }
    }
}