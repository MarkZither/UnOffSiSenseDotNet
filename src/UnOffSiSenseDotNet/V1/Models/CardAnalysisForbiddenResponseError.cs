// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CardAnalysisForbiddenResponseError
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CardAnalysisForbiddenResponseError class.
        /// </summary>
        public CardAnalysisForbiddenResponseError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CardAnalysisForbiddenResponseError class.
        /// </summary>
        public CardAnalysisForbiddenResponseError(int? code = default(int?), string message = default(string), int? status = default(int?), string httpMessage = default(string))
        {
            Code = code;
            Message = message;
            Status = status;
            HttpMessage = httpMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpMessage")]
        public string HttpMessage { get; set; }

    }
}
