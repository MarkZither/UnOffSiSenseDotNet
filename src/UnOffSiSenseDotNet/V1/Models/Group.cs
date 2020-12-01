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

    public partial class Group
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group(string _id = default(string), string name = default(string), string language = default(string), string mail = default(string), bool? ad = default(bool?), string roleId = default(string), string defaultRole = default(string), string objectSid = default(string), string dn = default(string), string uSNChanged = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? lastUpdated = default(System.DateTime?))
        {
            this._id = _id;
            Name = name;
            Language = language;
            Mail = mail;
            Ad = ad;
            RoleId = roleId;
            DefaultRole = defaultRole;
            ObjectSid = objectSid;
            Dn = dn;
            USNChanged = uSNChanged;
            Created = created;
            LastUpdated = lastUpdated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ad")]
        public bool? Ad { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public string RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultRole")]
        public string DefaultRole { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectSid")]
        public string ObjectSid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dn")]
        public string Dn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uSNChanged")]
        public string USNChanged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

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
                if (!System.Text.RegularExpressions.Regex.IsMatch(RoleId, "(^[0-9a-fA-F]{24}$|^[Nn][Uu][Ll]{2}$)"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "RoleId", "(^[0-9a-fA-F]{24}$|^[Nn][Uu][Ll]{2}$)");
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
