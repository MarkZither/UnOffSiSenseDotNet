// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// InfoRequest
    /// </summary>
    public partial class InfoRequest
    {
        /// <summary>
        /// Initializes a new instance of the InfoRequest class.
        /// </summary>
        public InfoRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfoRequest class.
        /// </summary>
        public InfoRequest(string instanceId = default(string), string physicalName = default(string))
        {
            InstanceId = instanceId;
            PhysicalName = physicalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "physicalName")]
        public string PhysicalName { get; set; }

    }
}
