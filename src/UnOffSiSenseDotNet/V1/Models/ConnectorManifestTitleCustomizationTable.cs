// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ConnectorManifestTitleCustomizationTable
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectorManifestTitleCustomizationTable class.
        /// </summary>
        public ConnectorManifestTitleCustomizationTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectorManifestTitleCustomizationTable class.
        /// </summary>
        public ConnectorManifestTitleCustomizationTable(string title = default(string), string translationKey = default(string))
        {
            Title = title;
            TranslationKey = translationKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "translationKey")]
        public string TranslationKey { get; set; }

    }
}
