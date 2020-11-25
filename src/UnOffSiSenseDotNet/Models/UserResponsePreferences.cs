// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserResponsePreferences
    {
        /// <summary>
        /// Initializes a new instance of the UserResponsePreferences class.
        /// </summary>
        public UserResponsePreferences()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserResponsePreferences class.
        /// </summary>
        public UserResponsePreferences(string localeId = default(string), string language = default(string))
        {
            LocaleId = localeId;
            Language = language;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "localeId")]
        public string LocaleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

    }
}
