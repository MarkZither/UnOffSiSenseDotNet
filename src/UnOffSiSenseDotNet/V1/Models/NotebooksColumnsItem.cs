// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NotebooksColumnsItem
    {
        /// <summary>
        /// Initializes a new instance of the NotebooksColumnsItem class.
        /// </summary>
        public NotebooksColumnsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NotebooksColumnsItem class.
        /// </summary>
        public NotebooksColumnsItem(string id = default(string), int? type = default(int?), string name = default(string))
        {
            Id = id;
            Type = type;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
