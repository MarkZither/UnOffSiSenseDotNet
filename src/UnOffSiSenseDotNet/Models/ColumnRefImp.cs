// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ColumnRefImp
    {
        /// <summary>
        /// Initializes a new instance of the ColumnRefImp class.
        /// </summary>
        public ColumnRefImp()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ColumnRefImp class.
        /// </summary>
        public ColumnRefImp(string columnName = default(string), string tableName = default(string))
        {
            ColumnName = columnName;
            TableName = tableName;
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
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }

    }
}
