// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatasetModelingTransformationsItemArgumentsItemModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatasetModelingTransformationsItemArgumentsItemModel class.
        /// </summary>
        public DatasetModelingTransformationsItemArgumentsItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatasetModelingTransformationsItemArgumentsItemModel class.
        /// </summary>
        public DatasetModelingTransformationsItemArgumentsItemModel(string table = default(string), string column = default(string))
        {
            Table = table;
            Column = column;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public string Column { get; set; }

    }
}
