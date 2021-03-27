using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFormInvoiceAPI.Business;
using WebFormInvoiceAPI.DomainObject;
using WebFormInvoiceAPI.Model;

namespace WebFormInvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMasterDataController :  ControllerBase
    {
        private readonly ILogger<GetMasterDataController> _logger;
        public GetMasterDataController(ILogger<GetMasterDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public GetMasterDataResponse Get()
        {
            ResultStatus rs = new ResultStatus();
            GetMasterDataResponse response = new GetMasterDataResponse();
            GetMasterData getData = new GetMasterData();
            rs = getData.GetData();

            response.IsSuccess = rs.IsSuccess;
            response.Message = rs.Message;
            response.Number = getData.Number;
            response.ListOfConsumen = getData.ListOfConsumen;
            response.ListOfCurrency = getData.ListOfCurrency;
            response.ListOfLanguage = getData.ListOfLanguage;
            response.ListOfUOM = getData.ListOfUOM;
            return response;
        }
    }
}
