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

    public partial class ServerPermissions
    {
        /// <summary>
        /// Initializes a new instance of the ServerPermissions class.
        /// </summary>
        public ServerPermissions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerPermissions class.
        /// </summary>
        public ServerPermissions(string party = default(string), string type = default(string), string permission = default(string))
        {
            Party = party;
            Type = type;
            Permission = permission;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "party")]
        public string Party { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Party != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Party, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Party", "^[0-9a-fA-F]{24}$");
                }
            }
        }
    }
}
