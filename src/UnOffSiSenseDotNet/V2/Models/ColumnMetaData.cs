// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ColumnMetaData
    /// </summary>
    public partial class ColumnMetaData
    {
        /// <summary>
        /// Initializes a new instance of the ColumnMetaData class.
        /// </summary>
        public ColumnMetaData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ColumnMetaData class.
        /// </summary>
        public ColumnMetaData(int? dataType = default(int?), string name = default(string))
        {
            DataType = dataType;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public int? DataType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
