// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DesignSettings
    {
        /// <summary>
        /// Initializes a new instance of the DesignSettings class.
        /// </summary>
        public DesignSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DesignSettings class.
        /// </summary>
        public DesignSettings(DesignSettingsTypography typography = default(DesignSettingsTypography), DesignSettingsGeneral general = default(DesignSettingsGeneral), DesignSettingsDashboards dashboards = default(DesignSettingsDashboards))
        {
            Typography = typography;
            General = general;
            Dashboards = dashboards;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typography")]
        public DesignSettingsTypography Typography { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "general")]
        public DesignSettingsGeneral General { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dashboards")]
        public DesignSettingsDashboards Dashboards { get; set; }

    }
}
