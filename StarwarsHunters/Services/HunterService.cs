using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StarwarsHunters.Services
{
    public class HunterService
    {
        HttpClient httpClient;
        List<Hunter> hunters;

        public HunterService()
        {
            this.httpClient = new HttpClient();
        }
        

        public async Task<List<Hunter>> GetHunters()
        {
            if (hunters?.Count > 0)
                return hunters;

            var response = await httpClient
                .GetStringAsync("https://paskihowest.github.io/StarwarsHunters/hunterdata.json");
            if(response != null)
                hunters = JsonConvert.DeserializeObject<List<Hunter>>(response);

            return hunters;
        }
    }
}
