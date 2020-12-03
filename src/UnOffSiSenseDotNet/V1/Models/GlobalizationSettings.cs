// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GlobalizationSettings
    {
        /// <summary>
        /// Initializes a new instance of the GlobalizationSettings class.
        /// </summary>
        public GlobalizationSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GlobalizationSettings class.
        /// </summary>
        /// <param name="language">Default language for localization.</param>
        public GlobalizationSettings(string language = default(string), GlobalizationSettingsLocalization localization = default(GlobalizationSettingsLocalization))
        {
            Language = language;
            Localization = localization;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets default language for localization.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "localization")]
        public GlobalizationSettingsLocalization Localization { get; set; }

    }
}