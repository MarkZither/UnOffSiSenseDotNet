// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EmailServerReporting
    {
        /// <summary>
        /// Initializes a new instance of the EmailServerReporting class.
        /// </summary>
        public EmailServerReporting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailServerReporting class.
        /// </summary>
        public EmailServerReporting(EmailServerReportingEndUserScheduling endUserScheduling = default(EmailServerReportingEndUserScheduling))
        {
            EndUserScheduling = endUserScheduling;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endUserScheduling")]
        public EmailServerReportingEndUserScheduling EndUserScheduling { get; set; }

    }
}