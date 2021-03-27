using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFormInvoiceAPI.DomainObject
{
    public class PurchaseOrders
    {
        public int ID { get; set; }
        public string PONo { get; set; }
        public int Amount { get; set; }
    }
}
