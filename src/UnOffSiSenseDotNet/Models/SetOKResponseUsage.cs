// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Usage Analytics feature properties block.
    /// </summary>
    public partial class SetOKResponseUsage
    {
        /// <summary>
        /// Initializes a new instance of the SetOKResponseUsage class.
        /// </summary>
        public SetOKResponseUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetOKResponseUsage class.
        /// </summary>
        /// <param name="enabled">Usage Analytics feature status.</param>
        /// <param name="restoreDashboards">On Usage Analytics feature
        /// enabling, system should restore dashboards, by default system
        /// restore dashboards on first Usage Analytics feature turn
        /// on.</param>
        public SetOKResponseUsage(bool? enabled = default(bool?), bool? restoreDashboards = default(bool?))
        {
            Enabled = enabled;
            RestoreDashboards = restoreDashboards;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets usage Analytics feature status.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets on Usage Analytics feature enabling, system should
        /// restore dashboards, by default system restore dashboards on first
        /// Usage Analytics feature turn on.
        /// </summary>
        [JsonProperty(PropertyName = "restoreDashboards")]
        public bool? RestoreDashboards { get; set; }

    }
}
