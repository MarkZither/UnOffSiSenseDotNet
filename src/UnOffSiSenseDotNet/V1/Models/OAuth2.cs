// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// OAuth2
    /// </summary>
    public partial class OAuth2
    {
        /// <summary>
        /// Initializes a new instance of the OAuth2 class.
        /// </summary>
        public OAuth2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OAuth2 class.
        /// </summary>
        public OAuth2(string baseUrl = default(string), string authorizationEndpoint = default(string), string accessTokenEndpoint = default(string), string clientId = default(string), string clientSecret = default(string), IList<string> scope = default(IList<string>))
        {
            BaseUrl = baseUrl;
            AuthorizationEndpoint = authorizationEndpoint;
            AccessTokenEndpoint = accessTokenEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Scope = scope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseUrl")]
        public string BaseUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessTokenEndpoint")]
        public string AccessTokenEndpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }

    }
}
