// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GatewayTimeouError
    {
        /// <summary>
        /// Initializes a new instance of the GatewayTimeouError class.
        /// </summary>
        public GatewayTimeouError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayTimeouError class.
        /// </summary>
        public GatewayTimeouError(GatewayTimeouErrorError error = default(GatewayTimeouErrorError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public GatewayTimeouErrorError Error { get; set; }

    }
}