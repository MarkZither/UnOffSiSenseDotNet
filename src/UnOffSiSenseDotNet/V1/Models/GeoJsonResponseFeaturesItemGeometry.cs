// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GeoJsonResponseFeaturesItemGeometry
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GeoJsonResponseFeaturesItemGeometry class.
        /// </summary>
        public GeoJsonResponseFeaturesItemGeometry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GeoJsonResponseFeaturesItemGeometry class.
        /// </summary>
        public GeoJsonResponseFeaturesItemGeometry(string type = default(string), IList<IList<object>> coordinates = default(IList<IList<object>>))
        {
            Type = type;
            Coordinates = coordinates;
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
        [JsonProperty(PropertyName = "coordinates")]
        public IList<IList<object>> Coordinates { get; set; }

    }
}
