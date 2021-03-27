using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFormInvoiceAPI.Model
{
    public class SaveInvoiceResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int Nomor { get; set; }
    }
}
