using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.ViewModels
{
    public class Invoice
    {
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public DateTime InvoiceDueDate { get; set; }
        [Required]
        public string BillTo { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string InvoiceNumber { get; set; }
        [Required]
        public string Notes { get; set; }
    }
}
