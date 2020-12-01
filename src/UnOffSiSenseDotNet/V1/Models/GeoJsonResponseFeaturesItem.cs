// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GeoJsonResponseFeaturesItem
    {
        /// <summary>
        /// Initializes a new instance of the GeoJsonResponseFeaturesItem
        /// class.
        /// </summary>
        public GeoJsonResponseFeaturesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoJsonResponseFeaturesItem
        /// class.
        /// </summary>
        public GeoJsonResponseFeaturesItem(string type = default(string), string id = default(string), object properties = default(object), GeoJsonResponseFeaturesItemGeometry geometry = default(GeoJsonResponseFeaturesItemGeometry))
        {
            Type = type;
            Id = id;
            Properties = properties;
            Geometry = geometry;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "geometry")]
        public GeoJsonResponseFeaturesItemGeometry Geometry { get; set; }

    }
}
