// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddToManifestByPathOKResponseManifest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AddToManifestByPathOKResponseManifest class.
        /// </summary>
        public AddToManifestByPathOKResponseManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AddToManifestByPathOKResponseManifest class.
        /// </summary>
        public AddToManifestByPathOKResponseManifest(AddToManifestByPathOKResponseManifestDashboards dashboards = default(AddToManifestByPathOKResponseManifestDashboards), AddToManifestByPathOKResponseManifestWidgets widgets = default(AddToManifestByPathOKResponseManifestWidgets))
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
        public AddToManifestByPathOKResponseManifestDashboards Dashboards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public AddToManifestByPathOKResponseManifestWidgets Widgets { get; set; }

    }
}
