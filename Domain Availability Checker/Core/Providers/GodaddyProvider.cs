using System;          
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using DomainAvailabilityChecker.Core.Models;   

namespace DomainAvailabilityChecker.Core.Providers
{
    public class GodaddyProvider : IDisposable
    {
        private const string UserAgent
            = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";

        private readonly HttpClient _client;
        private readonly JavaScriptSerializer _deserializer;

        public GodaddyProvider()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://www.godaddy.com/")
            };
            _deserializer = new JavaScriptSerializer();
        }

        public async Task<DomainReport> GetDomainReport(string domain)
        {                     
            var requestUrl = $"domainsapi/v1/search/exact?q={domain}&key=dpp_search&pc=&ptl=";
            var refererUrl = $"{_client.BaseAddress}domains/searchresults.aspx?checkAvail=1&domainToCheck={domain}";

            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);
            request.Headers.Accept.ParseAdd("application/json, text/plain");
            request.Headers.Referrer = new Uri(refererUrl);
            request.Headers.UserAgent.ParseAdd(UserAgent);

            var response = await _client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            try
            {
                var json = _deserializer.Deserialize<dynamic>(content);

                bool valid = json["ExactMatchDomain"]["IsValid"];
                bool available = json["ExactMatchDomain"]["IsAvailable"];

                if (valid && available)
                {
                    decimal price = json["Products"][0]["PriceInfo"]["CurrentPrice"];
                    return new DomainReport(domain, true, price);
                }

                return new DomainReport(domain, false);
            }
            catch (Exception)
            {
                return new DomainReport(domain, false);
            }  
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}