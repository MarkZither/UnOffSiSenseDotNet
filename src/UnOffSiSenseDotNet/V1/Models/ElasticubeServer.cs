// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ElasticubeServer
    {
        /// <summary>
        /// Initializes a new instance of the ElasticubeServer class.
        /// </summary>
        public ElasticubeServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticubeServer class.
        /// </summary>
        public ElasticubeServer(System.DateTime? lastUpdated = default(System.DateTime?), string owner = default(string), System.DateTime? created = default(System.DateTime?), string address = default(string), IList<object> defaultCubePermissions = default(IList<object>), string identity = default(string))
        {
            LastUpdated = lastUpdated;
            Owner = owner;
            Created = created;
            Address = address;
            DefaultCubePermissions = defaultCubePermissions;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultCubePermissions")]
        public IList<object> DefaultCubePermissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public string Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Owner != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Owner, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Owner", "^[0-9a-fA-F]{24}$");
                }
            }
        }
    }
}
