// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Duplicate
    /// </summary>
    public partial class Duplicate
    {
        /// <summary>
        /// Initializes a new instance of the Duplicate class.
        /// </summary>
        public Duplicate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Duplicate class.
        /// </summary>
        public Duplicate(string _id = default(string), int? timeout = default(int?), int? refreshRate = default(int?), string timezone = default(string))
        {
            this._id = _id;
            Timeout = timeout;
            RefreshRate = refreshRate;
            Timezone = timezone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "refreshRate")]
        public int? RefreshRate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

    }
}
