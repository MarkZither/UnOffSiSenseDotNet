// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LiveConnectionTableColumnsItem
    {
        /// <summary>
        /// Initializes a new instance of the LiveConnectionTableColumnsItem
        /// class.
        /// </summary>
        public LiveConnectionTableColumnsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveConnectionTableColumnsItem
        /// class.
        /// </summary>
        public LiveConnectionTableColumnsItem(string columnName = default(string), double? columnOrder = default(double?), double? dbType = default(double?), double? size = default(double?), double? precision = default(double?), double? scale = default(double?))
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
        public double? ColumnOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dbType")]
        public double? DbType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public double? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public double? Precision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scale")]
        public double? Scale { get; set; }

    }
}
