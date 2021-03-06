// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetSsoSettingsOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the SetSsoSettingsOKResponse class.
        /// </summary>
        public SetSsoSettingsOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetSsoSettingsOKResponse class.
        /// </summary>
        /// <param name="_id">ID of config.</param>
        /// <param name="name">Name of configuration.</param>
        /// <param name="enabled">If SSO is enabled.</param>
        /// <param name="ssoType">Type of SSO.</param>
        /// <param name="userCreationDisabled">This property enable/disable the
        /// automatic creation of users through SSO.</param>
        /// <param name="loginUrl">This is the URL that Sisense will invoke to
        /// attempt remote authentication.</param>
        /// <param name="logoutUrl">This is the URL that Sisense will return
        /// users to after they log out.</param>
        /// <param name="sharedSecret">Used in the token generation
        /// script.</param>
        /// <param name="loginUrlSaml">This is the URL that Sisense will invoke
        /// to attempt remote authentication via SAML.</param>
        /// <param name="logoutUrlSaml">This is the URL that Sisense will
        /// return users to after they log out via SAML.</param>
        /// <param name="idPCert">This is the certificate of identity
        /// provider.</param>
        /// <param name="lowSecurityJwtSso">Allow lower level security by
        /// disabling JTI enforcement.</param>
        /// <param name="syncGroupsFromSamlToken">Update the users' groups,
        /// based on the SAML attribute memberOf.</param>
        public SetSsoSettingsOKResponse(string _id = default(string), string name = default(string), bool? enabled = default(bool?), string ssoType = default(string), bool? userCreationDisabled = default(bool?), string loginUrl = default(string), string logoutUrl = default(string), string sharedSecret = default(string), string loginUrlSaml = default(string), string logoutUrlSaml = default(string), string idPCert = default(string), bool? lowSecurityJwtSso = default(bool?), bool? syncGroupsFromSamlToken = default(bool?))
        {
            this._id = _id;
            Name = name;
            Enabled = enabled;
            SsoType = ssoType;
            UserCreationDisabled = userCreationDisabled;
            LoginUrl = loginUrl;
            LogoutUrl = logoutUrl;
            SharedSecret = sharedSecret;
            LoginUrlSaml = loginUrlSaml;
            LogoutUrlSaml = logoutUrlSaml;
            IdPCert = idPCert;
            LowSecurityJwtSso = lowSecurityJwtSso;
            SyncGroupsFromSamlToken = syncGroupsFromSamlToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of config.
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// Gets or sets name of configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if SSO is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets type of SSO.
        /// </summary>
        [JsonProperty(PropertyName = "ssoType")]
        public string SsoType { get; set; }

        /// <summary>
        /// Gets or sets this property enable/disable the automatic creation of
        /// users through SSO.
        /// </summary>
        [JsonProperty(PropertyName = "userCreationDisabled")]
        public bool? UserCreationDisabled { get; set; }

        /// <summary>
        /// Gets or sets this is the URL that Sisense will invoke to attempt
        /// remote authentication.
        /// </summary>
        [JsonProperty(PropertyName = "loginUrl")]
        public string LoginUrl { get; set; }

        /// <summary>
        /// Gets or sets this is the URL that Sisense will return users to
        /// after they log out.
        /// </summary>
        [JsonProperty(PropertyName = "logoutUrl")]
        public string LogoutUrl { get; set; }

        /// <summary>
        /// Gets or sets used in the token generation script.
        /// </summary>
        [JsonProperty(PropertyName = "sharedSecret")]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Gets or sets this is the URL that Sisense will invoke to attempt
        /// remote authentication via SAML.
        /// </summary>
        [JsonProperty(PropertyName = "loginUrlSaml")]
        public string LoginUrlSaml { get; set; }

        /// <summary>
        /// Gets or sets this is the URL that Sisense will return users to
        /// after they log out via SAML.
        /// </summary>
        [JsonProperty(PropertyName = "logoutUrlSaml")]
        public string LogoutUrlSaml { get; set; }

        /// <summary>
        /// Gets or sets this is the certificate of identity provider.
        /// </summary>
        [JsonProperty(PropertyName = "idPCert")]
        public string IdPCert { get; set; }

        /// <summary>
        /// Gets or sets allow lower level security by disabling JTI
        /// enforcement.
        /// </summary>
        [JsonProperty(PropertyName = "lowSecurityJwtSso")]
        public bool? LowSecurityJwtSso { get; set; }

        /// <summary>
        /// Gets or sets update the users' groups, based on the SAML attribute
        /// memberOf.
        /// </summary>
        [JsonProperty(PropertyName = "syncGroupsFromSamlToken")]
        public bool? SyncGroupsFromSamlToken { get; set; }

    }
}
