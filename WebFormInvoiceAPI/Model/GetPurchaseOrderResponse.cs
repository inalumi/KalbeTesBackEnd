using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFormInvoiceAPI.DomainObject;

namespace WebFormInvoiceAPI.Model
{
    public class GetPurchaseOrderResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<PurchaseOrders> ListOfPurchaseOrder { get; set; }
    }
}
