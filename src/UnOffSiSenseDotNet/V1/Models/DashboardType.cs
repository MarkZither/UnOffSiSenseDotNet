// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DashboardType
    {
        /// <summary>
        /// Initializes a new instance of the DashboardType class.
        /// </summary>
        public DashboardType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DashboardType class.
        /// </summary>
        /// <param name="dashboardTypeProperty">Possible values include:
        /// 'owner', 'user'</param>
        public DashboardType(string dashboardTypeProperty = default(string))
        {
            DashboardTypeProperty = dashboardTypeProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'owner', 'user'
        /// </summary>
        [JsonProperty(PropertyName = "dashboardType")]
        public string DashboardTypeProperty { get; set; }

    }
}