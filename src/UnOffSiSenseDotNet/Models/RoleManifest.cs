// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RoleManifest
    {
        /// <summary>
        /// Initializes a new instance of the RoleManifest class.
        /// </summary>
        public RoleManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleManifest class.
        /// </summary>
        public RoleManifest(RoleManifestDashboards dashboards = default(RoleManifestDashboards), RoleManifestWidgets widgets = default(RoleManifestWidgets))
        {
            Dashboards = dashboards;
            Widgets = widgets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dashboards")]
        public RoleManifestDashboards Dashboards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public RoleManifestWidgets Widgets { get; set; }

    }
}
