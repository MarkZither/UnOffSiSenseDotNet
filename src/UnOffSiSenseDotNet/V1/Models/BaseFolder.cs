// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BaseFolder
    {
        /// <summary>
        /// Initializes a new instance of the BaseFolder class.
        /// </summary>
        public BaseFolder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseFolder class.
        /// </summary>
        public BaseFolder(string name = default(string), string parentId = default(string))
        {
            Name = name;
            ParentId = parentId;
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
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }

    }
}
