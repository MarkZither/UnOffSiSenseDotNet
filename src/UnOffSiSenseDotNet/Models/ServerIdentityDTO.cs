// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ServerIdentityDTO
    /// </summary>
    public partial class ServerIdentityDTO
    {
        /// <summary>
        /// Initializes a new instance of the ServerIdentityDTO class.
        /// </summary>
        public ServerIdentityDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerIdentityDTO class.
        /// </summary>
        public ServerIdentityDTO(string identity = default(string))
        {
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public string Identity { get; set; }

    }
}
