// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetRoleByIdOrNameOKResponseManifest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetRoleByIdOrNameOKResponseManifest class.
        /// </summary>
        public GetRoleByIdOrNameOKResponseManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetRoleByIdOrNameOKResponseManifest class.
        /// </summary>
        public GetRoleByIdOrNameOKResponseManifest(GetRoleByIdOrNameOKResponseManifestDashboards dashboards = default(GetRoleByIdOrNameOKResponseManifestDashboards), GetRoleByIdOrNameOKResponseManifestWidgets widgets = default(GetRoleByIdOrNameOKResponseManifestWidgets))
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
        public GetRoleByIdOrNameOKResponseManifestDashboards Dashboards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public GetRoleByIdOrNameOKResponseManifestWidgets Widgets { get; set; }

    }
}