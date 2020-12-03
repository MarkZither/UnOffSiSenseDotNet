// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UniforecastPayload
    {
        /// <summary>
        /// Initializes a new instance of the UniforecastPayload class.
        /// </summary>
        public UniforecastPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UniforecastPayload class.
        /// </summary>
        /// <param name="horizon">An integer larger than 0 indicating how many
        /// future periods to forecast</param>
        /// <param name="level">Period date level. Possible values include:
        /// 'day', 'week', 'month', 'quarter', 'year'</param>
        /// <param name="data">JSON object that hold value for each
        /// date</param>
        /// <param name="model">forecast model to use. Possible values include:
        /// 'en', 'aa', 'hw', 'fb'</param>
        public UniforecastPayload(long? horizon = default(long?), string level = default(string), IList<UniforecastPayloadDataItem> data = default(IList<UniforecastPayloadDataItem>), string model = default(string), double? eBar = default(double?), UniforecastPayloadBoundaries boundaries = default(UniforecastPayloadBoundaries))
        {
            Horizon = horizon;
            Level = level;
            Data = data;
            Model = model;
            EBar = eBar;
            Boundaries = boundaries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an integer larger than 0 indicating how many future
        /// periods to forecast
        /// </summary>
        [JsonProperty(PropertyName = "horizon")]
        public long? Horizon { get; set; }

        /// <summary>
        /// Gets or sets period date level. Possible values include: 'day',
        /// 'week', 'month', 'quarter', 'year'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets JSON object that hold value for each date
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<UniforecastPayloadDataItem> Data { get; set; }

        /// <summary>
        /// Gets or sets forecast model to use. Possible values include: 'en',
        /// 'aa', 'hw', 'fb'
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eBar")]
        public double? EBar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "boundaries")]
        public UniforecastPayloadBoundaries Boundaries { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EBar != null)
            {
                if (EBar > 99)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "EBar", 99);
                }
                if (EBar < 50)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "EBar", 50);
                }
            }
        }
    }
}