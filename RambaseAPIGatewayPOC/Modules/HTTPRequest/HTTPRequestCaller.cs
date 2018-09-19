using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RambaseAPIGatewayPOC.Caller
{
    public class HTTPRequestCaller
    {
        public static async Task<string> sendRequestAsync(string url, string content) {
            HttpContent httpContent = new StringContent(content, Encoding.UTF8, "text/plain");
            string result = "";
            using (HttpClient hc = new HttpClient())
            {
                HttpResponseMessage response = await hc.PostAsync(url, httpContent);
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }
    }
}
