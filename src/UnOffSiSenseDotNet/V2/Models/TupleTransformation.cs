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
    /// TupleTransformation
    /// </summary>
    public partial class TupleTransformation
    {
        /// <summary>
        /// Initializes a new instance of the TupleTransformation class.
        /// </summary>
        public TupleTransformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TupleTransformation class.
        /// </summary>
        public TupleTransformation(Arguments arguments = default(Arguments), string lastUpdated = default(string), string type = default(string))
        {
            Arguments = arguments;
            LastUpdated = lastUpdated;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public Arguments Arguments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
