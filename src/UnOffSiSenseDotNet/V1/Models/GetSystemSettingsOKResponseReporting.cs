// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetSystemSettingsOKResponseReporting
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GetSystemSettingsOKResponseReporting class.
        /// </summary>
        public GetSystemSettingsOKResponseReporting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GetSystemSettingsOKResponseReporting class.
        /// </summary>
        public GetSystemSettingsOKResponseReporting(GetSystemSettingsOKResponseReportingEndUserScheduling endUserScheduling = default(GetSystemSettingsOKResponseReportingEndUserScheduling))
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
        public GetSystemSettingsOKResponseReportingEndUserScheduling EndUserScheduling { get; set; }

    }
}
