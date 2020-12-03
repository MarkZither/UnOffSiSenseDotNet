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

    public partial class DataContextOfLiveElasticubeSharesItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataContextOfLiveElasticubeSharesItem class.
        /// </summary>
        public DataContextOfLiveElasticubeSharesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataContextOfLiveElasticubeSharesItem class.
        /// </summary>
        /// <param name="type">Possible values include: 'user', 'group',
        /// 'default'</param>
        public DataContextOfLiveElasticubeSharesItem(string type, string partyId = default(string))
        {
            PartyId = partyId;
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
        /// Gets or sets possible values include: 'user', 'group', 'default'
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