// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateCustomModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateCustomModel class.
        /// </summary>
        public UpdateCustomModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateCustomModel class.
        /// </summary>
        public UpdateCustomModel(object model = default(object))
        {
            Model = model;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public object Model { get; set; }

    }
}
