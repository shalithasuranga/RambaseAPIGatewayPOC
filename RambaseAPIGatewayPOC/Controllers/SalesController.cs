using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RambaseAPIGatewayPOC.Caller;
using RambaseAPIGatewayPOC.Modules.ServerlessFunctions.Sales;

namespace RambaseAPIGatewayPOC.Controllers
{
    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        // GET api/sales
        [HttpGet]
        public string Index()
        {
            return "RamBase API Gateway POC";
        }
         
        [EnableCors("Policy")]
        [HttpGet("orderitem/{id}")]
        public async Task<string> GetOrderItemsByIdAsync(int id) {
            GetOrderItemsByIdFunction function = new GetOrderItemsByIdFunction(id.ToString());
            return await function.getOutputAsync();
        }

        [EnableCors("Policy")]
        [HttpGet("orders")]
        public async Task<string> GetOrdersAsync(int id) {
            GetSalesOrdersFunction function = new GetSalesOrdersFunction(id.ToString());
            return await function.getOutputAsync();
        }


        [EnableCors("Policy")]
        [HttpGet("invoices")]
        public string GetInvoices(int id) {
            return "{\"invoices\":[{\"invoiceNo\":\"EF23\",\"date\":\"May 2018\",\"client\":\"ABC Enterprises\",\"location\":\"Montainview CA\",\"status\":\"Pending\",\"by\":\"Alex Cartin\",\"amount\":25000}]}";
        }



    }
}
