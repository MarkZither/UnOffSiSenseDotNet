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
    /// LogicalDbSchema
    /// </summary>
    public partial class LogicalDbSchema
    {
        /// <summary>
        /// Initializes a new instance of the LogicalDbSchema class.
        /// </summary>
        public LogicalDbSchema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogicalDbSchema class.
        /// </summary>
        public LogicalDbSchema(IList<LogicalRelationship> relationships = default(IList<LogicalRelationship>), string schemaId = default(string), string schemaName = default(string), IList<LogicalDataTable> tables = default(IList<LogicalDataTable>))
        {
            Relationships = relationships;
            SchemaId = schemaId;
            SchemaName = schemaName;
            Tables = tables;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relationships")]
        public IList<LogicalRelationship> Relationships { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaId")]
        public string SchemaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<LogicalDataTable> Tables { get; set; }

    }
}
