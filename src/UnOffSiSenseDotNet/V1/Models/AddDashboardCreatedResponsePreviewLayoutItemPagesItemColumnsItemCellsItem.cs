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

    public partial class AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItem
        /// class.
        /// </summary>
        public AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItem
        /// class.
        /// </summary>
        public AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItem(IList<AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItemSubcellsItem> subcells = default(IList<AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItemSubcellsItem>))
        {
            Subcells = subcells;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcells")]
        public IList<AddDashboardCreatedResponsePreviewLayoutItemPagesItemColumnsItemCellsItemSubcellsItem> Subcells { get; set; }

    }
}
