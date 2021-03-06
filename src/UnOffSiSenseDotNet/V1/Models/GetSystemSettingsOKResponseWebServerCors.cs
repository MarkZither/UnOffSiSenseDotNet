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

    public partial class GetSystemSettingsOKResponseWebServerCors
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetSystemSettingsOKResponseWebServerCors class.
        /// </summary>
        public GetSystemSettingsOKResponseWebServerCors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetSystemSettingsOKResponseWebServerCors class.
        /// </summary>
        /// <param name="enabled">If cors settings is enabled.</param>
        public GetSystemSettingsOKResponseWebServerCors(bool? enabled = default(bool?), IList<string> allowedOrigins = default(IList<string>))
        {
            Enabled = enabled;
            AllowedOrigins = allowedOrigins;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if cors settings is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedOrigins")]
        public IList<string> AllowedOrigins { get; set; }

    }
}
