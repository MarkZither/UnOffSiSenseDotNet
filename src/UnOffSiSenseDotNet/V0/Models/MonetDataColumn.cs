// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MonetDataColumn
    {
        /// <summary>
        /// Initializes a new instance of the MonetDataColumn class.
        /// </summary>
        public MonetDataColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MonetDataColumn class.
        /// </summary>
        public MonetDataColumn(string columnName = default(string), string monetColumnType = default(string), string logicalColumnType = default(string), bool? indexed = default(bool?), string columnPhysicalName = default(string), bool? isGeneratedColumn = default(bool?), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            ColumnName = columnName;
            MonetColumnType = monetColumnType;
            LogicalColumnType = logicalColumnType;
            Indexed = indexed;
            ColumnPhysicalName = columnPhysicalName;
            IsGeneratedColumn = isGeneratedColumn;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "monetColumnType")]
        public string MonetColumnType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logicalColumnType")]
        public string LogicalColumnType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "indexed")]
        public bool? Indexed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnPhysicalName")]
        public string ColumnPhysicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isGeneratedColumn")]
        public bool? IsGeneratedColumn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

    }
}