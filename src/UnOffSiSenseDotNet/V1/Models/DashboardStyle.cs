// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DashboardStyle
    {
        /// <summary>
        /// Initializes a new instance of the DashboardStyle class.
        /// </summary>
        public DashboardStyle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DashboardStyle class.
        /// </summary>
        public DashboardStyle(string name = default(string), DashboardStylePalette palette = default(DashboardStylePalette))
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
        public DashboardStylePalette Palette { get; set; }

    }
}
