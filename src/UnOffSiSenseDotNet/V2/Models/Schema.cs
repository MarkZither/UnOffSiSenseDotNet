// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Schema
    /// </summary>
    public partial class Schema
    {
        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        public Schema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        public Schema(string id = default(string), IList<Table> tables = default(IList<Table>))
        {
            Id = id;
            Tables = tables;
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
        [JsonProperty(PropertyName = "tables")]
        public IList<Table> Tables { get; set; }

    }
}
