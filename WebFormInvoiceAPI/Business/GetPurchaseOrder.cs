using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFormInvoiceAPI.DomainObject;
using WebFormInvoiceAPI.Model;

namespace WebFormInvoiceAPI.Business
{
    public class GetPurchaseOrder
    {
        private InvoiceContext context;
        public List<PurchaseOrders> ListOfPurchaseOrder { get; private set; }
        public GetPurchaseOrder()
        {
            this.ListOfPurchaseOrder = new List<PurchaseOrders>();

            context = new InvoiceContext();
        }

        public ResultStatus GetData()
        {
            ResultStatus rs = new ResultStatus();
            rs.SetSuccessStatus("Sukses");
            try
            {
                this.ListOfPurchaseOrder = context.PurchaseOrders.ToList();
            }
            catch (Exception ex)
            {
                rs.SetErrorStatus(ex.ToString());
            }

            return rs;
        }
    }
}
