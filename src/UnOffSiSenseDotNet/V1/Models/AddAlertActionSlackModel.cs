// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddAlertActionSlackModel
    {
        /// <summary>
        /// Initializes a new instance of the AddAlertActionSlackModel class.
        /// </summary>
        public AddAlertActionSlackModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddAlertActionSlackModel class.
        /// </summary>
        public AddAlertActionSlackModel(bool? active = default(bool?), string url = default(string), string channels = default(string))
        {
            Active = active;
            Url = url;
            Channels = channels;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public string Channels { get; set; }

    }
}
