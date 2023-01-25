using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangeRates.Services
{
    public class ExchangeRateService : IExchangeRateService
    {
        static HttpClient client = new HttpClient();
        public async Task<string> GetExchangeRateAsync()
        {
            string resultContent = await client.GetStringAsync("https://boi.org.il/PublicApi/GetExchangeRates?asXML=true");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(resultContent);


            return JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, true);
        }
    }
}
