using System;
using Newtonsoft.Json;

namespace app.Models
{
    /// <summary>
    /// Represents an Item in the database.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Unique Id property.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Date and time.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}