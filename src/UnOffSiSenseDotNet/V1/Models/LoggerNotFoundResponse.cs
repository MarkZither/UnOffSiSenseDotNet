// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LoggerNotFoundResponse
    {
        /// <summary>
        /// Initializes a new instance of the LoggerNotFoundResponse class.
        /// </summary>
        public LoggerNotFoundResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoggerNotFoundResponse class.
        /// </summary>
        public LoggerNotFoundResponse(LoggerNotFoundResponseError error = default(LoggerNotFoundResponseError))
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
        public LoggerNotFoundResponseError Error { get; set; }

    }
}
