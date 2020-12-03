// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ContextElement
    /// </summary>
    public partial class ContextElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextElement class.
        /// </summary>
        public ContextElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContextElement class.
        /// </summary>
        /// <param name="type">Possible values include: 'COLUMNS',
        /// 'TABLES'</param>
        public ContextElement(string type = default(string), string value = default(string))
        {
            Type = type;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'COLUMNS', 'TABLES'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}