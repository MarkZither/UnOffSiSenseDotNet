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

    public partial class DatasetSchemaTablesItemModel
    {
        /// <summary>
        /// Initializes a new instance of the DatasetSchemaTablesItemModel
        /// class.
        /// </summary>
        public DatasetSchemaTablesItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetSchemaTablesItemModel
        /// class.
        /// </summary>
        public DatasetSchemaTablesItemModel(string id = default(string), string name = default(string), IList<DatasetSchemaTablesItemColumnsItemModel> columns = default(IList<DatasetSchemaTablesItemColumnsItemModel>), IList<DatasetSchemaTablesItemTupleTransformationsItemModel> tupleTransformations = default(IList<DatasetSchemaTablesItemTupleTransformationsItemModel>))
        {
            Id = id;
            Name = name;
            Columns = columns;
            TupleTransformations = tupleTransformations;
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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<DatasetSchemaTablesItemColumnsItemModel> Columns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tuple-transformations")]
        public IList<DatasetSchemaTablesItemTupleTransformationsItemModel> TupleTransformations { get; set; }

    }
}
