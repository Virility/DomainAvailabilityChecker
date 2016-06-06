using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Domain_Availability_Checker
{
    internal class Domain
    {
        public int Index { get; }
        public string Url { get; }
        public string Available { get; private set; }
        public string Price { get; private set; }

        public Domain(int index, string url, string available)
        {
            Index = index;
            Url = url;
            Available = available;
        }

        public void Check()
        {
            HttpWebRequest request = WebRequest.CreateHttp($"https://nl.godaddy.com/domainsapi/v1/search/exact?q={Url}&key=dpp_search&pc=&ptl=");
            request.Accept = "application/json, text/plain, */*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36";
            request.Referer = $"https://nl.godaddy.com/domains/searchresults.aspx?checkAvail=1&domainToCheck={Url}";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string source = reader.ReadToEnd();
                    JavaScriptSerializer deserializer = new JavaScriptSerializer();
                    dynamic json = deserializer.Deserialize<dynamic>(source);
                    bool available = json["ExactMatchDomain"]["IsAvailable"];
                    Available = available.ToString();
                    
                    if(available)
                        Price = json["Products"][0]["PriceInfo"]["ListPriceDisplay"];
                }
            }
        }
    }
}
