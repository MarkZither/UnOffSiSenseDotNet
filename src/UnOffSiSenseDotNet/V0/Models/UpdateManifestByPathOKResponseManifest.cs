// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateManifestByPathOKResponseManifest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateManifestByPathOKResponseManifest class.
        /// </summary>
        public UpdateManifestByPathOKResponseManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateManifestByPathOKResponseManifest class.
        /// </summary>
        public UpdateManifestByPathOKResponseManifest(UpdateManifestByPathOKResponseManifestDashboards dashboards = default(UpdateManifestByPathOKResponseManifestDashboards), UpdateManifestByPathOKResponseManifestWidgets widgets = default(UpdateManifestByPathOKResponseManifestWidgets))
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
        public UpdateManifestByPathOKResponseManifestDashboards Dashboards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public UpdateManifestByPathOKResponseManifestWidgets Widgets { get; set; }

    }
}
