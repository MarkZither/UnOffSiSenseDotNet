// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetCardsNamesNotFoundResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetCardsNamesNotFoundResponse
        /// class.
        /// </summary>
        public GetCardsNamesNotFoundResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetCardsNamesNotFoundResponse
        /// class.
        /// </summary>
        public GetCardsNamesNotFoundResponse(GetCardsNamesNotFoundResponseError error = default(GetCardsNamesNotFoundResponseError))
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
        public GetCardsNamesNotFoundResponseError Error { get; set; }

    }
}
