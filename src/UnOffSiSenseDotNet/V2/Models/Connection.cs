// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Connection
    /// </summary>
    public partial class Connection
    {
        /// <summary>
        /// Initializes a new instance of the Connection class.
        /// </summary>
        public Connection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Connection class.
        /// </summary>
        public Connection(object parameters = default(object), string provider = default(string), long? resultLimit = default(long?), string schema = default(string), int? timeout = default(int?))
        {
            Parameters = parameters;
            Provider = provider;
            ResultLimit = resultLimit;
            Schema = schema;
            Timeout = timeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object Parameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resultLimit")]
        public long? ResultLimit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }

    }
}
