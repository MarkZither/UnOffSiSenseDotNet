// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GenerateNewNotFoundResponse
    {
        /// <summary>
        /// Initializes a new instance of the GenerateNewNotFoundResponse
        /// class.
        /// </summary>
        public GenerateNewNotFoundResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateNewNotFoundResponse
        /// class.
        /// </summary>
        public GenerateNewNotFoundResponse(GenerateNewNotFoundResponseError error = default(GenerateNewNotFoundResponseError))
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
        public GenerateNewNotFoundResponseError Error { get; set; }

    }
}
