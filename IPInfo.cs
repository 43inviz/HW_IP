using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




using System.Net.Http;
using Newtonsoft.Json;

namespace HW_IP_app
{
    internal static class IPInfo
    {

        public static async void GetInfoByIP(string ip)
        {
            string url = $"http://ipwho.is/{ip}?fields=city,country";

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                if (content.Length > 0)
                {
                    Response data = JsonConvert.DeserializeObject<Response>(content);

                    string fullPath = $"../../Response/{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}.json";

                    Console.WriteLine($"Country: {data.Country} City: {data.City}");
                    SaveResponseToFile(fullPath, data);
                }

                else
                {
                    throw new Exception("Invalid IP");
                }
            }

        }

        public static void SaveResponseToFile(string fileName,Response resp)
        {
            string json = JsonConvert.SerializeObject(resp);
            File.WriteAllText(fileName,json);
                
        }


    }

    
}
