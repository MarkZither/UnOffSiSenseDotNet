// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatasetTableTupleTransformationsItemArguments
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatasetTableTupleTransformationsItemArguments class.
        /// </summary>
        public DatasetTableTupleTransformationsItemArguments()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatasetTableTupleTransformationsItemArguments class.
        /// </summary>
        public DatasetTableTupleTransformationsItemArguments(string column = default(string))
        {
            Column = column;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public string Column { get; set; }

    }
}
