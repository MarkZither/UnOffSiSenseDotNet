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

    public partial class DatasetToAddModelingTransformationsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatasetToAddModelingTransformationsItem class.
        /// </summary>
        public DatasetToAddModelingTransformationsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatasetToAddModelingTransformationsItem class.
        /// </summary>
        /// <param name="type">Possible values include: 'join'</param>
        public DatasetToAddModelingTransformationsItem(string type = default(string), IList<DatasetToAddModelingTransformationsItemArgumentsItem> arguments = default(IList<DatasetToAddModelingTransformationsItemArgumentsItem>))
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
        /// Gets or sets possible values include: 'join'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public IList<DatasetToAddModelingTransformationsItemArgumentsItem> Arguments { get; set; }

    }
}
