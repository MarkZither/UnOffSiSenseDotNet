// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendReportsOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the SendReportsOKResponse class.
        /// </summary>
        public SendReportsOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendReportsOKResponse class.
        /// </summary>
        /// <param name="senderRole">Sender user role name</param>
        /// <param name="recipients">Recipients info</param>
        /// <param name="mail">Mail sent info</param>
        public SendReportsOKResponse(string senderRole = default(string), SendReportsOKResponseRecipients recipients = default(SendReportsOKResponseRecipients), SendReportsOKResponseMail mail = default(SendReportsOKResponseMail))
        {
            SenderRole = senderRole;
            Recipients = recipients;
            Mail = mail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sender user role name
        /// </summary>
        [JsonProperty(PropertyName = "senderRole")]
        public string SenderRole { get; set; }

        /// <summary>
        /// Gets or sets recipients info
        /// </summary>
        [JsonProperty(PropertyName = "recipients")]
        public SendReportsOKResponseRecipients Recipients { get; set; }

        /// <summary>
        /// Gets or sets mail sent info
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public SendReportsOKResponseMail Mail { get; set; }

    }
}
