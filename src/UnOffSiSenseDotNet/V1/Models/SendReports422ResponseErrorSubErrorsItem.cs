// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SendReports422ResponseErrorSubErrorsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SendReports422ResponseErrorSubErrorsItem class.
        /// </summary>
        public SendReports422ResponseErrorSubErrorsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SendReports422ResponseErrorSubErrorsItem class.
        /// </summary>
        public SendReports422ResponseErrorSubErrorsItem(SendReports422ResponseErrorSubErrorsItemError error = default(SendReports422ResponseErrorSubErrorsItemError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public SendReports422ResponseErrorSubErrorsItemError Error { get; set; }

    }
}
