// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateEvent
    {
        /// <summary>
        /// Initializes a new instance of the UpdateEvent class.
        /// </summary>
        public UpdateEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateEvent class.
        /// </summary>
        public UpdateEvent(bool? seen = default(bool?), bool? hide = default(bool?))
        {
            Seen = seen;
            Hide = hide;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "seen")]
        public bool? Seen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hide")]
        public bool? Hide { get; set; }

    }
}
