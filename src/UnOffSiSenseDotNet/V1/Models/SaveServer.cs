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

    public partial class SaveServer
    {
        /// <summary>
        /// Initializes a new instance of the SaveServer class.
        /// </summary>
        public SaveServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SaveServer class.
        /// </summary>
        public SaveServer(string token, string cookieType, string server, string userName, string deviceId = default(string), string expiration = default(string), string issueDate = default(string))
        {
            Token = token;
            CookieType = cookieType;
            Server = server;
            UserName = userName;
            DeviceId = deviceId;
            Expiration = expiration;
            IssueDate = issueDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cookieType")]
        public string CookieType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issueDate")]
        public string IssueDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Token == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Token");
            }
            if (CookieType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CookieType");
            }
            if (Server == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Server");
            }
            if (UserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserName");
            }
        }
    }
}
