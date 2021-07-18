using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public decimal Total { get; set; }
    }
}
