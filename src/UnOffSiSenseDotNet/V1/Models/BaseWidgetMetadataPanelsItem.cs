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

    public partial class BaseWidgetMetadataPanelsItem
    {
        /// <summary>
        /// Initializes a new instance of the BaseWidgetMetadataPanelsItem
        /// class.
        /// </summary>
        public BaseWidgetMetadataPanelsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseWidgetMetadataPanelsItem
        /// class.
        /// </summary>
        public BaseWidgetMetadataPanelsItem(string name = default(string), IList<BaseWidgetMetadataPanelsItemItemsItem> items = default(IList<BaseWidgetMetadataPanelsItemItemsItem>))
        {
            Name = name;
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<BaseWidgetMetadataPanelsItemItemsItem> Items { get; set; }

    }
}