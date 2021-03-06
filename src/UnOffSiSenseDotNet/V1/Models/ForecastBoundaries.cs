// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ForecastBoundaries
    {
        /// <summary>
        /// Initializes a new instance of the ForecastBoundaries class.
        /// </summary>
        public ForecastBoundaries()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ForecastBoundaries class.
        /// </summary>
        /// <param name="lower">The lowest allowed value in the forecast
        /// series</param>
        /// <param name="upper">The highest allowed value in the forecast
        /// series</param>
        /// <param name="isInt">If true, all forecasted values will be rounded
        /// to a whole number</param>
        public ForecastBoundaries(double? lower = default(double?), double? upper = default(double?), bool? isInt = default(bool?))
        {
            Lower = lower;
            Upper = upper;
            IsInt = isInt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the lowest allowed value in the forecast series
        /// </summary>
        [JsonProperty(PropertyName = "lower")]
        public double? Lower { get; set; }

        /// <summary>
        /// Gets or sets the highest allowed value in the forecast series
        /// </summary>
        [JsonProperty(PropertyName = "upper")]
        public double? Upper { get; set; }

        /// <summary>
        /// Gets or sets if true, all forecasted values will be rounded to a
        /// whole number
        /// </summary>
        [JsonProperty(PropertyName = "isInt")]
        public bool? IsInt { get; set; }

    }
}
