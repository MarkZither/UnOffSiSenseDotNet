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
    /// TableColumn
    /// </summary>
    public partial class TableColumn
    {
        /// <summary>
        /// Initializes a new instance of the TableColumn class.
        /// </summary>
        public TableColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TableColumn class.
        /// </summary>
        public TableColumn(string columnName = default(string), int? columnOrder = default(int?), int? dbType = default(int?), int? size = default(int?), int? precision = default(int?), int? scale = default(int?))
        {
            ColumnName = columnName;
            ColumnOrder = columnOrder;
            DbType = dbType;
            Size = size;
            Precision = precision;
            Scale = scale;
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
        [JsonProperty(PropertyName = "columnOrder")]
        public int? ColumnOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dbType")]
        public int? DbType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scale")]
        public int? Scale { get; set; }

    }
}
