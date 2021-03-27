using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFormInvoiceAPI.DomainObject;
using WebFormInvoiceAPI.Model;

namespace WebFormInvoiceAPI.Business
{
    public class GetMasterData
    {
        private InvoiceContext context;

        public int Number { get; private set; }
        public List<Consumen> ListOfConsumen { get; private set; }
        public List<Currencys> ListOfCurrency { get; private set; }
        public List<Language> ListOfLanguage { get; private set; }
        public List<UOMS> ListOfUOM { get; private set; }
        public GetMasterData()
        {
            this.ListOfConsumen = new List<Consumen>();
            this.ListOfCurrency = new List<Currencys>();
            this.ListOfLanguage = new List<Language>();
            this.ListOfUOM = new List<UOMS>();

            context = new InvoiceContext();
        }

        public ResultStatus GetData()
        {
            ResultStatus rs = new ResultStatus();
            rs.SetSuccessStatus("Sukses");
            try
            {
                this.ListOfConsumen = context.Consumen.ToList();
                this.ListOfCurrency = context.Currencys.ToList();
                this.ListOfLanguage = context.Language.ToList();
                this.ListOfUOM = context.UOMS.ToList();
                this.Number = context.Number.ToList().FirstOrDefault().Nomor;
            }
            catch(Exception ex)
            {
                rs.SetErrorStatus(ex.ToString());
            }            

            return rs;
        }
    }
}
