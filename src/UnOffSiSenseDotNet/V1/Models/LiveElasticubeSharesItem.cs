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

    public partial class LiveElasticubeSharesItem
    {
        /// <summary>
        /// Initializes a new instance of the LiveElasticubeSharesItem class.
        /// </summary>
        public LiveElasticubeSharesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveElasticubeSharesItem class.
        /// </summary>
        /// <param name="permission">Possible values include: 'a', 'r',
        /// 'w'</param>
        /// <param name="type">Possible values include: 'user', 'group'</param>
        public LiveElasticubeSharesItem(string partyId, string permission, string type)
        {
            PartyId = partyId;
            Permission = permission;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyId")]
        public string PartyId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'a', 'r', 'w'
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'user', 'group'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PartyId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PartyId");
            }
            if (Permission == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permission");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (PartyId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(PartyId, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "PartyId", "^[0-9a-fA-F]{24}$");
                }
            }
        }
    }
}
