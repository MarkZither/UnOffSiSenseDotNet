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

    public partial class BaseDashboardPreviewLayoutItemPagesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BaseDashboardPreviewLayoutItemPagesItem class.
        /// </summary>
        public BaseDashboardPreviewLayoutItemPagesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BaseDashboardPreviewLayoutItemPagesItem class.
        /// </summary>
        public BaseDashboardPreviewLayoutItemPagesItem(string type = default(string), IList<BaseDashboardPreviewLayoutItemPagesItemColumnsItem> columns = default(IList<BaseDashboardPreviewLayoutItemPagesItemColumnsItem>))
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
        public IList<BaseDashboardPreviewLayoutItemPagesItemColumnsItem> Columns { get; set; }

    }
}