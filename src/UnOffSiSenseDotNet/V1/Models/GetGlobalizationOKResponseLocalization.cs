// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetGlobalizationOKResponseLocalization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetGlobalizationOKResponseLocalization class.
        /// </summary>
        public GetGlobalizationOKResponseLocalization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetGlobalizationOKResponseLocalization class.
        /// </summary>
        /// <param name="defaultProperty">Default locale for
        /// localization.</param>
        /// <param name="autoDetectEnabled">If language autodetect is
        /// enabled.</param>
        public GetGlobalizationOKResponseLocalization(string defaultProperty = default(string), bool? autoDetectEnabled = default(bool?))
        {
            DefaultProperty = defaultProperty;
            AutoDetectEnabled = autoDetectEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets default locale for localization.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public string DefaultProperty { get; set; }

        /// <summary>
        /// Gets or sets if language autodetect is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "autoDetectEnabled")]
        public bool? AutoDetectEnabled { get; set; }

    }
}
