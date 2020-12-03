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
    /// LogicalRelationship
    /// </summary>
    public partial class LogicalRelationship
    {
        /// <summary>
        /// Initializes a new instance of the LogicalRelationship class.
        /// </summary>
        public LogicalRelationship()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogicalRelationship class.
        /// </summary>
        /// <param name="logicalColumnType">Possible values include: 'BIGINT',
        /// 'DATETIME', 'DECIMAL', 'FLOAT', 'INT', 'REAL', 'TEXT'</param>
        public LogicalRelationship(IList<ColumnRefImp> columnRefs = default(IList<ColumnRefImp>), string logicalColumnType = default(string), string relationshipId = default(string))
        {
            ColumnRefs = columnRefs;
            LogicalColumnType = logicalColumnType;
            RelationshipId = relationshipId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnRefs")]
        public IList<ColumnRefImp> ColumnRefs { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'BIGINT', 'DATETIME',
        /// 'DECIMAL', 'FLOAT', 'INT', 'REAL', 'TEXT'
        /// </summary>
        [JsonProperty(PropertyName = "logicalColumnType")]
        public string LogicalColumnType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relationshipId")]
        public string RelationshipId { get; set; }

    }
}