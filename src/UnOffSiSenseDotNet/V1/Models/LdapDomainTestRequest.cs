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

    public partial class LdapDomainTestRequest
    {
        /// <summary>
        /// Initializes a new instance of the LdapDomainTestRequest class.
        /// </summary>
        public LdapDomainTestRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LdapDomainTestRequest class.
        /// </summary>
        public LdapDomainTestRequest(string _id = default(string), string url = default(string), string baseDN = default(string), string username = default(string), string password = default(string), bool? sslEnabled = default(bool?), string pfxCertificate = default(string), string pfxKey = default(string))
        {
            this._id = _id;
            Url = url;
            BaseDN = baseDN;
            Username = username;
            Password = password;
            SslEnabled = sslEnabled;
            PfxCertificate = pfxCertificate;
            PfxKey = pfxKey;
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
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseDN")]
        public string BaseDN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sslEnabled")]
        public bool? SslEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pfxCertificate")]
        public string PfxCertificate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pfxKey")]
        public string PfxKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (_id != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(_id, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "_id", "^[0-9a-fA-F]{24}$");
                }
            }
            if (Url != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Url, "^ldap|ldaps\\:\\/\\/.+"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Url", "^ldap|ldaps\\:\\/\\/.+");
                }
            }
        }
    }
}