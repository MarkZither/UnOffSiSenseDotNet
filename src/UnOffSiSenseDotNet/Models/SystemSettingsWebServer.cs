// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SystemSettingsWebServer
    {
        /// <summary>
        /// Initializes a new instance of the SystemSettingsWebServer class.
        /// </summary>
        public SystemSettingsWebServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SystemSettingsWebServer class.
        /// </summary>
        /// <param name="enableSSl">If SSL is enabled.</param>
        public SystemSettingsWebServer(bool? enableSSl = default(bool?), SystemSettingsWebServerCors cors = default(SystemSettingsWebServerCors))
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
        public SystemSettingsWebServerCors Cors { get; set; }

    }
}
