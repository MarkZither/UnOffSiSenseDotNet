// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DashboardPreviewLayoutItemPagesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DashboardPreviewLayoutItemPagesItem class.
        /// </summary>
        public DashboardPreviewLayoutItemPagesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DashboardPreviewLayoutItemPagesItem class.
        /// </summary>
        public DashboardPreviewLayoutItemPagesItem(string type = default(string), IList<DashboardPreviewLayoutItemPagesItemColumnsItem> columns = default(IList<DashboardPreviewLayoutItemPagesItemColumnsItem>))
        {
            Type = type;
            Columns = columns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<DashboardPreviewLayoutItemPagesItemColumnsItem> Columns { get; set; }

    }
}