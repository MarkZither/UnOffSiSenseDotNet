// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ElasticubeRelationToAddColumnsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ElasticubeRelationToAddColumnsItem class.
        /// </summary>
        public ElasticubeRelationToAddColumnsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ElasticubeRelationToAddColumnsItem class.
        /// </summary>
        public ElasticubeRelationToAddColumnsItem(string dataset = default(string), string table = default(string), string column = default(string))
        {
            Dataset = dataset;
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
        [JsonProperty(PropertyName = "dataset")]
        public string Dataset { get; set; }

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