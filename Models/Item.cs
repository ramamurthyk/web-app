using System;
using Newtonsoft.Json;

namespace app.Models
{
    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public DateTime Timestamp { get; set; }
    }
}