// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DashboardFiltersItem
    {
        /// <summary>
        /// Initializes a new instance of the DashboardFiltersItem class.
        /// </summary>
        public DashboardFiltersItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DashboardFiltersItem class.
        /// </summary>
        public DashboardFiltersItem(DashboardFiltersItemJaql jaql = default(DashboardFiltersItemJaql))
        {
            Jaql = jaql;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jaql")]
        public DashboardFiltersItemJaql Jaql { get; set; }

    }
}