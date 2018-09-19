using RambaseAPIGatewayPOC.Caller;
using RambaseAPIGatewayPOC.Modules.Utils.XML2JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RambaseAPIGatewayPOC.Modules.ServerlessFunctions.Sales
{
    public class ServerlessFunction
    {
        protected string input;
        protected string url;

        public ServerlessFunction(string input) {
            this.input = input;
        }

        public async Task<string> getOutputAsync() {
            string res = await HTTPRequestCaller.sendRequestAsync(this.url, this.input);
            return XML2JSON.convert(res);
        }
    }
}