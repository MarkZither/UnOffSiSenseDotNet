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

    public partial class GetOwnedDashboardsOKResponseItemStylePalette
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetOwnedDashboardsOKResponseItemStylePalette class.
        /// </summary>
        public GetOwnedDashboardsOKResponseItemStylePalette()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetOwnedDashboardsOKResponseItemStylePalette class.
        /// </summary>
        public GetOwnedDashboardsOKResponseItemStylePalette(IList<string> colors = default(IList<string>), string name = default(string), bool? isSystem = default(bool?))
        {
            Colors = colors;
            Name = name;
            IsSystem = isSystem;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "colors")]
        public IList<string> Colors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSystem")]
        public bool? IsSystem { get; set; }

    }
}