// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetForbiddenResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetForbiddenResponse class.
        /// </summary>
        public GetForbiddenResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetForbiddenResponse class.
        /// </summary>
        public GetForbiddenResponse(GetForbiddenResponseError error = default(GetForbiddenResponseError))
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
        public GetForbiddenResponseError Error { get; set; }

    }
}
