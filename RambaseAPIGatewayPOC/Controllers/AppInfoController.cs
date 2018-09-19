using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RambaseAPIGatewayPOC.Controllers
{
    [Produces("application/json")]
    [Route("api/appinfo")]
    public class AppInfoController : Controller
    {

        [EnableCors("Policy")]
        [HttpGet("app1")]
        public string GetInvoices(int id) {
            return "{\"appVersion\":\"v1.0.0\",\"appId\":\"1234\",\"appMatch\":\"app1\",\"layout\":{},\"componentList\":[{\"appVersion\":\"v1.0.0\",\"appId\":\"1234\",\"appMatch\":\"noticeBoard\",\"layout\":{},\"componentList\":null},{\"appVersion\":\"v1.0.0\",\"appId\":\"1234\",\"appMatch\":\"loadInvoices\",\"layout\":{},\"componentList\":null},{\"appVersion\":\"v1.0.0\",\"appId\":\"1234\",\"appMatch\":\"createInvoice\",\"layout\":{},\"componentList\":null}]}";
        }


    }
}