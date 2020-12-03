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

    public partial class LdapDomainResponse
    {
        /// <summary>
        /// Initializes a new instance of the LdapDomainResponse class.
        /// </summary>
        public LdapDomainResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LdapDomainResponse class.
        /// </summary>
        public LdapDomainResponse(string _id = default(string), bool? enabled = default(bool?), string url = default(string), string baseDN = default(string), string username = default(string), string name = default(string), string syncUsn = default(string), bool? syncActive = default(bool?), int? syncInterval = default(int?), bool? sslEnabled = default(bool?))
        {
            this._id = _id;
            Enabled = enabled;
            Url = url;
            BaseDN = baseDN;
            Username = username;
            Name = name;
            SyncUsn = syncUsn;
            SyncActive = syncActive;
            SyncInterval = syncInterval;
            SslEnabled = sslEnabled;
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
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

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
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncUsn")]
        public string SyncUsn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncActive")]
        public bool? SyncActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "syncInterval")]
        public int? SyncInterval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sslEnabled")]
        public bool? SslEnabled { get; set; }

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
        }
    }
}