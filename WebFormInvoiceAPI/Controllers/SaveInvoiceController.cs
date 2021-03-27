using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebFormInvoiceAPI.Business;
using WebFormInvoiceAPI.DomainObject;
using WebFormInvoiceAPI.Model;

namespace WebFormInvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class SaveInvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public SaveInvoiceResponse Post(SaveInvoiceRequest request)
        {
            ResultStatus rs = new ResultStatus();
            SaveInvoiceResponse response = new SaveInvoiceResponse();
            SaveInvoice save = new SaveInvoice(request.invoiceno, request.language, request.currency, request.from,
                request.nameto, request.alamatto, request.duedate, request.invoicedue, request.pono, request.subtotal,
                request.discountamount, request.total, request.detail);
            rs = save.Save();
            response.IsSuccess = rs.IsSuccess;
            response.Message = rs.Message;
            response.Nomor = save.Nomor;
            return response;
        }
    }
}
