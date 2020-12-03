// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SecuritySettings
    {
        /// <summary>
        /// Initializes a new instance of the SecuritySettings class.
        /// </summary>
        public SecuritySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecuritySettings class.
        /// </summary>
        public SecuritySettings(string name = default(string), bool? allowAddServers = default(bool?), string secret = default(string))
        {
            Name = name;
            AllowAddServers = allowAddServers;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowAddServers")]
        public bool? AllowAddServers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

    }
}