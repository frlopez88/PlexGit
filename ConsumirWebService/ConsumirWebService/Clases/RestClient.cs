using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWebService.Clases
{
    public class RestClient
    {

        public async Task<T> Get<T> (string url) 
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
            
        }

    }
}
