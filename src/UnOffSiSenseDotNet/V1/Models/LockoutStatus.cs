// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LockoutStatus
    {
        /// <summary>
        /// Initializes a new instance of the LockoutStatus class.
        /// </summary>
        public LockoutStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LockoutStatus class.
        /// </summary>
        public LockoutStatus(bool? blocked = default(bool?), string blockedUntil = default(string))
        {
            Blocked = blocked;
            BlockedUntil = blockedUntil;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "blockedUntil")]
        public string BlockedUntil { get; set; }

    }
}
