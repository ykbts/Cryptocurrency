using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cryptocurrency.Models
{
    public class CoinTop
    {
        [JsonProperty("coins")]
        public List<Coins> Coins { get; set; }
    }

    public class Coins
    {
        [JsonProperty("item")]
        public Item Item { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

}