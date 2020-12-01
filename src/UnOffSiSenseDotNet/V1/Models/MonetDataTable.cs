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

    /// <summary>
    /// MonetDataTable
    /// </summary>
    public partial class MonetDataTable
    {
        /// <summary>
        /// Initializes a new instance of the MonetDataTable class.
        /// </summary>
        public MonetDataTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonetDataTable class.
        /// </summary>
        public MonetDataTable(IList<PhysicalDataColumn> columns = default(IList<PhysicalDataColumn>), bool? isGeneratedTable = default(bool?), bool? isHidden = default(bool?), string logicalTableName = default(string), string schemaName = default(string), string tablePhysicalName = default(string))
        {
            Columns = columns;
            IsGeneratedTable = isGeneratedTable;
            IsHidden = isHidden;
            LogicalTableName = logicalTableName;
            SchemaName = schemaName;
            TablePhysicalName = tablePhysicalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<PhysicalDataColumn> Columns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isGeneratedTable")]
        public bool? IsGeneratedTable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isHidden")]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logicalTableName")]
        public string LogicalTableName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tablePhysicalName")]
        public string TablePhysicalName { get; set; }

    }
}
