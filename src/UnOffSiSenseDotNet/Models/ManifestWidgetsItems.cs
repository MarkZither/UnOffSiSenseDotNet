// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ManifestWidgetsItems
    {
        /// <summary>
        /// Initializes a new instance of the ManifestWidgetsItems class.
        /// </summary>
        public ManifestWidgetsItems()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManifestWidgetsItems class.
        /// </summary>
        public ManifestWidgetsItems(bool? modifyType = default(bool?), bool? onOff = default(bool?), bool? reorder = default(bool?))
        {
            ModifyType = modifyType;
            OnOff = onOff;
            Reorder = reorder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modify_type")]
        public bool? ModifyType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "on_off")]
        public bool? OnOff { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reorder")]
        public bool? Reorder { get; set; }

    }
}
