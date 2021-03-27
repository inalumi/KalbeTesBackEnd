using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFormInvoiceAPI.DomainObject;

namespace WebFormInvoiceAPI.Model
{
    public class GetMasterDataResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int Number { get; set; }
        public List<Consumen> ListOfConsumen { get; set; }
        public List<Currencys> ListOfCurrency { get; set; }
        public List<Language> ListOfLanguage { get; set; }
        public List<UOMS> ListOfUOM { get; set; }
    }
}
