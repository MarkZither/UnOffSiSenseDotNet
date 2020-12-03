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

    public partial class AdGroup
    {
        /// <summary>
        /// Initializes a new instance of the AdGroup class.
        /// </summary>
        public AdGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdGroup class.
        /// </summary>
        public AdGroup(string name = default(string), string cn = default(string), string roleId = default(string), string objectSid = default(string), string dn = default(string))
        {
            Name = name;
            Cn = cn;
            RoleId = roleId;
            ObjectSid = objectSid;
            Dn = dn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cn")]
        public string Cn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public string RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectSid")]
        public string ObjectSid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dn")]
        public string Dn { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RoleId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(RoleId, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "RoleId", "^[0-9a-fA-F]{24}$");
                }
            }
            if (ObjectSid != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ObjectSid, "^\\[\\d{1,3}(?:,\\d{1,3}){27}\\]$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ObjectSid", "^\\[\\d{1,3}(?:,\\d{1,3}){27}\\]$");
                }
            }
        }
    }
}