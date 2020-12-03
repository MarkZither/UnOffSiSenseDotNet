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

    public partial class MultiforecastPayload
    {
        /// <summary>
        /// Initializes a new instance of the MultiforecastPayload class.
        /// </summary>
        public MultiforecastPayload()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MultiforecastPayload class.
        /// </summary>
        /// <param name="horizon">An integer larger than 0 indicating how many
        /// future periods to forecast</param>
        /// <param name="level">Period date level. Possible values include:
        /// 'day', 'week', 'month', 'quarter', 'year'</param>
        /// <param name="data">JSON object that hold value for each
        /// date</param>
        /// <param name="type">2nd Horizion type. Possible values include:
        /// 'uni-forecast', 'last', 'customValues'</param>
        public MultiforecastPayload(long? horizon = default(long?), string level = default(string), IList<MultiforecastPayloadDataItem> data = default(IList<MultiforecastPayloadDataItem>), string type = default(string), IList<int?> customValues = default(IList<int?>), MultiforecastPayloadBoundaries boundaries = default(MultiforecastPayloadBoundaries))
        {
            Horizon = horizon;
            Level = level;
            Data = data;
            Type = type;
            CustomValues = customValues;
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
        public IList<MultiforecastPayloadDataItem> Data { get; set; }

        /// <summary>
        /// Gets or sets 2nd Horizion type. Possible values include:
        /// 'uni-forecast', 'last', 'customValues'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customValues")]
        public IList<int?> CustomValues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "boundaries")]
        public MultiforecastPayloadBoundaries Boundaries { get; set; }

    }
}