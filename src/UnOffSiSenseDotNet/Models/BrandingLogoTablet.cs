// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BrandingLogoTablet
    {
        /// <summary>
        /// Initializes a new instance of the BrandingLogoTablet class.
        /// </summary>
        public BrandingLogoTablet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BrandingLogoTablet class.
        /// </summary>
        public BrandingLogoTablet(string large = default(string), string small = default(string))
        {
            Large = large;
            Small = small;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "large")]
        public string Large { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }

    }
}
