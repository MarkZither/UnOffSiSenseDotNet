// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatasetSchedule
    {
        /// <summary>
        /// Initializes a new instance of the DatasetSchedule class.
        /// </summary>
        public DatasetSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetSchedule class.
        /// </summary>
        public DatasetSchedule(string type = default(string))
        {
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}