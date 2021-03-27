using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFormInvoiceAPI.DomainObject
{
    public class InvoiceHeader
    {
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public string From { get; set; }
        public string NameTo { get; set; }
        public string AlamatTo { get; set; }
        public DateTime DueDate { get; set; }
        public string InvoiceDue { get; set; }
        public string PONo { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
    }
}
