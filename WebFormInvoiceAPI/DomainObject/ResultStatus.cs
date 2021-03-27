using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFormInvoiceAPI.DomainObject
{
    public class ResultStatus
    {
        public bool IsSuccess { get; private set; }
        public string Message { get; set; }

        public void SetSuccessStatus(string message)
        {
            this.IsSuccess = true;
            this.Message = message;
        }
        public void SetErrorStatus(string message)
        {
            this.IsSuccess = false;
            this.Message = message;
        }
    }
}
