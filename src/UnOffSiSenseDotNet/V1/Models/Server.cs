// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Server
    {
        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Server class.
        /// </summary>
        public Server(string serverProperty)
        {
            ServerProperty = serverProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string ServerProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ServerProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServerProperty");
            }
        }
    }
}
