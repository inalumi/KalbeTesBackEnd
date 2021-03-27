using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFormInvoiceAPI.DomainObject;
using WebFormInvoiceAPI.Model;

namespace WebFormInvoiceAPI.Business
{
    public class SaveInvoice
    {
        public int Nomor { get; set; }
        private InvoiceContext context;
        private InvoiceHeader Header { get; set; }
        private List<InvoiceDetail> ListOfDetail { get; set; }
        public SaveInvoice(string invoiceno, string language, string currency, string from, string nameto, 
            string alamatto, string duedate, string invoicedue, string pono, decimal subtotal, decimal discount,
            decimal total, List<Detail> detail)
        {
            Header = new InvoiceHeader();
            Header.AlamatTo = alamatto;
            Header.Currency = currency;
            Header.DiscountAmount = discount;
            Header.DueDate = !string.IsNullOrEmpty(duedate) ? Convert.ToDateTime(duedate).Date : DateTime.Now.Date;
            Header.From = from;
            Header.InvoiceDue = invoicedue;
            Header.InvoiceNo = invoiceno;
            Header.Language = language;
            Header.NameTo = nameto;
            Header.PONo = pono;
            Header.SubTotal = subtotal;
            Header.Total = total;

            ListOfDetail = new List<InvoiceDetail>();
            foreach(var data in detail)
            {
                InvoiceDetail det = new InvoiceDetail();
                det.Amount = data.amount;
                det.Description = data.description;
                det.Qty = data.qty;
                det.Rate = data.rate;
                ListOfDetail.Add(det);
            }

            context = new InvoiceContext();
        }

        public ResultStatus Save()
        {
            ResultStatus rs = new ResultStatus();
            rs.SetSuccessStatus("Invoice No " + Header.InvoiceNo + " has been saved");
            try
            {
                Number num = context.Number.ToList().FirstOrDefault();
                if (num != null && num.ID > 0)
                {
                    num.Nomor++;
                    Nomor = num.Nomor;
                    context.Entry(num).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    var datas = context.SaveChangesAsync().Result;
                }

                context = new InvoiceContext();
                context.InvoiceHeader.Add(Header);
                context.SaveChanges();

                if (Header.ID > 0)
                {
                    foreach (var data in ListOfDetail)
                    {
                        context = new InvoiceContext();
                        data.InvoiceHeaderID = Header.ID;
                        context.InvoiceDetail.Add(data);
                        context.SaveChanges();
                    }
                }
            }
            catch(Exception ex) { rs.SetErrorStatus(ex.ToString()); }

            return rs;
        }
    }
}
