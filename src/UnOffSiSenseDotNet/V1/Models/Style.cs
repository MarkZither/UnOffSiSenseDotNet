// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Style
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style(string name = default(string), StylePalette palette = default(StylePalette))
        {
            Name = name;
            Palette = palette;
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
        [JsonProperty(PropertyName = "palette")]
        public StylePalette Palette { get; set; }

    }
}
