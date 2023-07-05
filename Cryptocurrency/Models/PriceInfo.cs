using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoApp.Models
{
    public class PriceInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tickers")]
        public List<Tickers> Tickers { get; set; }
    }

    public class Tickers
    {
        [JsonProperty("volume")]
        public long Volume { get; set; }

        [JsonProperty("trade_url")]
        public string TradeUrl { get; set; }

        [JsonProperty("converted_last")]
        public ConvertedLast ConvertedLast { get; set; }

        [JsonProperty("market")]
        public Market Market { get; set; }
    }

    public class ConvertedLast
    {
        [JsonProperty("btc")]
        public double Btc { get; set; }

        [JsonProperty("eth")]
        public double Eth { get; set; }

        [JsonProperty("usd")]
        public double Usd { get; set; }
    }

    public class Market
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}