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

    public partial class ForecastMultiDataItem
    {
        /// <summary>
        /// Initializes a new instance of the ForecastMultiDataItem class.
        /// </summary>
        public ForecastMultiDataItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ForecastMultiDataItem class.
        /// </summary>
        public ForecastMultiDataItem(System.DateTime? date = default(System.DateTime?), double? value = default(double?), double? value2 = default(double?))
        {
            Date = date;
            Value = value;
            Value2 = value2;
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

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value2")]
        public double? Value2 { get; set; }

    }
}