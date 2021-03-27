using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFormInvoiceAPI.DomainObject
{
    public class InvoiceDetail
    {
        public int ID { get; set; }
        public int InvoiceHeaderID { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
