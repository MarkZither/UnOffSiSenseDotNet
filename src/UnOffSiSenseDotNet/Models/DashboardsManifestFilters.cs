// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DashboardsManifestFilters
    {
        /// <summary>
        /// Initializes a new instance of the DashboardsManifestFilters class.
        /// </summary>
        public DashboardsManifestFilters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DashboardsManifestFilters class.
        /// </summary>
        public DashboardsManifestFilters(bool? advanced = default(bool?), bool? create = default(bool?), bool? modifyType = default(bool?), bool? onOff = default(bool?), bool? toggleAutoUpdate = default(bool?), bool? toggleExpansion = default(bool?))
        {
            Advanced = advanced;
            Create = create;
            ModifyType = modifyType;
            OnOff = onOff;
            ToggleAutoUpdate = toggleAutoUpdate;
            ToggleExpansion = toggleExpansion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "advanced")]
        public bool? Advanced { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "create")]
        public bool? Create { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modify_type")]
        public bool? ModifyType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "on_off")]
        public bool? OnOff { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toggle_auto_update")]
        public bool? ToggleAutoUpdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toggle_expansion")]
        public bool? ToggleExpansion { get; set; }

    }
}
