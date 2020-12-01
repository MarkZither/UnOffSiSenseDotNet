// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SystemSettingsEmail
    {
        /// <summary>
        /// Initializes a new instance of the SystemSettingsEmail class.
        /// </summary>
        public SystemSettingsEmail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SystemSettingsEmail class.
        /// </summary>
        /// <param name="enabled">If mails are enabled.</param>
        /// <param name="senderEmail">Email of sender.</param>
        /// <param name="senderName">Name of sender.</param>
        public SystemSettingsEmail(bool? enabled = default(bool?), string senderEmail = default(string), string senderName = default(string))
        {
            Enabled = enabled;
            SenderEmail = senderEmail;
            SenderName = senderName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if mails are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets email of sender.
        /// </summary>
        [JsonProperty(PropertyName = "senderEmail")]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Gets or sets name of sender.
        /// </summary>
        [JsonProperty(PropertyName = "senderName")]
        public string SenderName { get; set; }

    }
}
