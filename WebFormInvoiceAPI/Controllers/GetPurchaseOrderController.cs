using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebFormInvoiceAPI.Business;
using WebFormInvoiceAPI.DomainObject;
using WebFormInvoiceAPI.Model;

namespace WebFormInvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetPurchaseOrderController : ControllerBase
    {
        private readonly ILogger<GetPurchaseOrderController> _logger;
        public GetPurchaseOrderController(ILogger<GetPurchaseOrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<PurchaseOrders> Get()
        {
            ResultStatus rs = new ResultStatus();
            List<PurchaseOrders> listPO = new List<PurchaseOrders>();
             GetPurchaseOrderResponse response = new GetPurchaseOrderResponse();
            GetPurchaseOrder getData = new GetPurchaseOrder();
            rs = getData.GetData();

            if (rs.IsSuccess)
            {
               listPO  = getData.ListOfPurchaseOrder;
            }
            return listPO;
        }
    }
}
