// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateDeploymentId
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDeploymentId class.
        /// </summary>
        public UpdateDeploymentId()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDeploymentId class.
        /// </summary>
        /// <param name="alias">Alias for deployment</param>
        public UpdateDeploymentId(string alias)
        {
            Alias = alias;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets alias for deployment
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Alias == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Alias");
            }
        }
    }
}
