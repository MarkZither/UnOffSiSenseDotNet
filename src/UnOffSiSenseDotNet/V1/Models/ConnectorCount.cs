// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ConnectorCount
    /// </summary>
    public partial class ConnectorCount
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorCount class.
        /// </summary>
        public ConnectorCount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorCount class.
        /// </summary>
        public ConnectorCount(string count = default(string))
        {
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public string Count { get; set; }

    }
}
