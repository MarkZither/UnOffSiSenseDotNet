// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BaseDashboardFiltersItem
    {
        /// <summary>
        /// Initializes a new instance of the BaseDashboardFiltersItem class.
        /// </summary>
        public BaseDashboardFiltersItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseDashboardFiltersItem class.
        /// </summary>
        public BaseDashboardFiltersItem(BaseDashboardFiltersItemJaql jaql = default(BaseDashboardFiltersItemJaql))
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
        public BaseDashboardFiltersItemJaql Jaql { get; set; }

    }
}