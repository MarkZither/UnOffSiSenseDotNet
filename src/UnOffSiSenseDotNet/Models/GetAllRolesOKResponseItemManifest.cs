// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetAllRolesOKResponseItemManifest
    {
        /// <summary>
        /// Initializes a new instance of the GetAllRolesOKResponseItemManifest
        /// class.
        /// </summary>
        public GetAllRolesOKResponseItemManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetAllRolesOKResponseItemManifest
        /// class.
        /// </summary>
        public GetAllRolesOKResponseItemManifest(GetAllRolesOKResponseItemManifestDashboards dashboards = default(GetAllRolesOKResponseItemManifestDashboards), GetAllRolesOKResponseItemManifestWidgets widgets = default(GetAllRolesOKResponseItemManifestWidgets))
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
        public GetAllRolesOKResponseItemManifestDashboards Dashboards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public GetAllRolesOKResponseItemManifestWidgets Widgets { get; set; }

    }
}
