using RambaseAPIGatewayPOC.Caller;
using RambaseAPIGatewayPOC.Modules.Utils.XML2JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RambaseAPIGatewayPOC.Modules.ServerlessFunctions.Sales
{
    public class GetSalesOrdersFunction : ServerlessFunction {
        public GetSalesOrdersFunction(string input) : base(input) {
            base.url = Environment.GetEnvironmentVariable("GETORDERS_FUNCTION_URL") == null ? "http://172.20.5.91:31112/function/get-sales-orders" : Environment.GetEnvironmentVariable("GETORDERS_FUNCTION_URL");
        }

    }
}
