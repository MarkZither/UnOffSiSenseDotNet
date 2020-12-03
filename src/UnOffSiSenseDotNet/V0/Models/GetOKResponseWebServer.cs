// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetOKResponseWebServer
    {
        /// <summary>
        /// Initializes a new instance of the GetOKResponseWebServer class.
        /// </summary>
        public GetOKResponseWebServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetOKResponseWebServer class.
        /// </summary>
        /// <param name="enableSSl">If SSL is enabled.</param>
        public GetOKResponseWebServer(bool? enableSSl = default(bool?), GetOKResponseWebServerCors cors = default(GetOKResponseWebServerCors))
        {
            EnableSSl = enableSSl;
            Cors = cors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if SSL is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableSSl")]
        public bool? EnableSSl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cors")]
        public GetOKResponseWebServerCors Cors { get; set; }

    }
}