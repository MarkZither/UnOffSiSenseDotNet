// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UniforecastPayloadDataItem
    {
        /// <summary>
        /// Initializes a new instance of the UniforecastPayloadDataItem class.
        /// </summary>
        public UniforecastPayloadDataItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UniforecastPayloadDataItem class.
        /// </summary>
        public UniforecastPayloadDataItem(System.DateTime? date = default(System.DateTime?), double? value = default(double?))
        {
            Date = date;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}
