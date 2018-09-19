using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace RambaseAPIGatewayPOC.Modules.Utils.XML2JSON
{
    public class XML2JSON
    {
        public static string convert(string xml) {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            string json = JsonConvert.SerializeXmlNode(doc);
            return json;
        }
    }
}
