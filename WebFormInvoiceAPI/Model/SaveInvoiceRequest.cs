using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFormInvoiceAPI.Model
{
    //currency: document.getElementById("currency").value,
    //            from: document.getElementById("from").value,
    //            nameto: document.getElementById("consumen").value,
    //            alamatto: document.getElementById("alamatto").value,
    //            duedate: document.getElementById("duedate").value,
    //            invoicedue: document.getElementById("invoicedue").value,
    //            pono: document.getElementById("PoNo").value,
    //            detail: detail,
    //            subtotal: document.getElementById("subtotal").value,
    //            discountvalue: document.getElementById("DiscountValue").value,
    //            total: document.getElementById("total").value
    public class SaveInvoiceRequest
    {
        public string invoiceno { get; set; }
        public string language { get; set; }
        public string currency { get; set; }
        public string from { get; set; }
        public string nameto { get; set; }
        public string alamatto { get; set; }
        public string duedate { get; set; }
        public string invoicedue { get; set; }
        public string pono { get; set; }
        public decimal subtotal { get; set; }
        public decimal discountamount { get; set; }
        public decimal total { get; set; }
        public List<Detail> detail { get; set; }

    }

    public class Detail
    {
        public string description { get; set; }
        public decimal qty { get; set; }
        public decimal rate { get; set; }
        public decimal amount { get; set; }
    }
}
