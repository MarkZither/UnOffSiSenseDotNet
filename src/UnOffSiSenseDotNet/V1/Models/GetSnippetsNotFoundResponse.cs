// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetSnippetsNotFoundResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetSnippetsNotFoundResponse
        /// class.
        /// </summary>
        public GetSnippetsNotFoundResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetSnippetsNotFoundResponse
        /// class.
        /// </summary>
        public GetSnippetsNotFoundResponse(GetSnippetsNotFoundResponseError error = default(GetSnippetsNotFoundResponseError))
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
        public GetSnippetsNotFoundResponseError Error { get; set; }

    }
}
