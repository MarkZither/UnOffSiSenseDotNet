// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetManifestByPathOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetManifestByPathOKResponse
        /// class.
        /// </summary>
        public GetManifestByPathOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetManifestByPathOKResponse
        /// class.
        /// </summary>
        public GetManifestByPathOKResponse(GetManifestByPathOKResponseDashboards dashboards = default(GetManifestByPathOKResponseDashboards), GetManifestByPathOKResponseWidgets widgets = default(GetManifestByPathOKResponseWidgets))
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
        public GetManifestByPathOKResponseDashboards Dashboards { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "widgets")]
        public GetManifestByPathOKResponseWidgets Widgets { get; set; }

    }
}