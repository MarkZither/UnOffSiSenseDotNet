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

    public partial class BaseDashboardLayoutColumnsItemCellsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BaseDashboardLayoutColumnsItemCellsItem class.
        /// </summary>
        public BaseDashboardLayoutColumnsItemCellsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BaseDashboardLayoutColumnsItemCellsItem class.
        /// </summary>
        public BaseDashboardLayoutColumnsItemCellsItem(IList<BaseDashboardLayoutColumnsItemCellsItemSubcellsItem> subcells = default(IList<BaseDashboardLayoutColumnsItemCellsItemSubcellsItem>))
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
        public IList<BaseDashboardLayoutColumnsItemCellsItemSubcellsItem> Subcells { get; set; }

    }
}
