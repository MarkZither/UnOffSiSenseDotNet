// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LocationsResponseContextItem
    {
        /// <summary>
        /// Initializes a new instance of the LocationsResponseContextItem
        /// class.
        /// </summary>
        public LocationsResponseContextItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationsResponseContextItem
        /// class.
        /// </summary>
        public LocationsResponseContextItem(string id = default(string), string shortCode = default(string), string text = default(string), string wikidata = default(string))
        {
            Id = id;
            ShortCode = shortCode;
            Text = text;
            Wikidata = wikidata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "wikidata")]
        public string Wikidata { get; set; }

    }
}