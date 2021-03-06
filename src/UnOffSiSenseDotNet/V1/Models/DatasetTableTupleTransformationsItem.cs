// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatasetTableTupleTransformationsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatasetTableTupleTransformationsItem class.
        /// </summary>
        public DatasetTableTupleTransformationsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatasetTableTupleTransformationsItem class.
        /// </summary>
        /// <param name="type">Possible values include: 'change-data-type',
        /// 'replace-nulls', 'split-column', 'hide-column',
        /// 'rename-column'</param>
        public DatasetTableTupleTransformationsItem(string type = default(string), DatasetTableTupleTransformationsItemArguments arguments = default(DatasetTableTupleTransformationsItemArguments))
        {
            Type = type;
            Arguments = arguments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'change-data-type',
        /// 'replace-nulls', 'split-column', 'hide-column', 'rename-column'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public DatasetTableTupleTransformationsItemArguments Arguments { get; set; }

    }
}
