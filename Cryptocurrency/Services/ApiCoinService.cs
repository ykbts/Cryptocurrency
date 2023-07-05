using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cryptocurrency.Models;
using CryptoApp.Models;

namespace Cryptocurrency.Services
{
    public class ApiCoinService
    {
        private const string _trendUrl = "https://api.coingecko.com/api/v3/search/trending";
        private const string _tickersUrl = "https://api.coingecko.com/api/v3/coins/";

        public async Task<CoinTop> GetTop()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(_trendUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<CoinTop>(content);
                    return result;
                }
                else
                {
                    throw new Exception("Api-trend error");
                }
            }
        }
     
        public async Task<PriceInfo> GetPriceInfo(string id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{_tickersUrl}{id}/tickers");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<PriceInfo>(content);
                    return result;
                }
                else
                {
                    throw new Exception("Api-price error");
                }
            }
        }
    }
}
