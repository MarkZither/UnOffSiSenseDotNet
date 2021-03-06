// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the SetOKResponseModel class.
        /// </summary>
        public SetOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetOKResponseModel class.
        /// </summary>
        /// <param name="name">Name of configuration.</param>
        /// <param name="language">Default language for localization.</param>
        public SetOKResponseModel(string name = default(string), string language = default(string), SetOKResponseLocalization localization = default(SetOKResponseLocalization))
        {
            Name = name;
            Language = language;
            Localization = localization;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets default language for localization.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "localization")]
        public SetOKResponseLocalization Localization { get; set; }

    }
}
