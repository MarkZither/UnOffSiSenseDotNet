// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetNotFoundResponse
    {
        /// <summary>
        /// Initializes a new instance of the SetNotFoundResponse class.
        /// </summary>
        public SetNotFoundResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetNotFoundResponse class.
        /// </summary>
        public SetNotFoundResponse(SetNotFoundResponseError error = default(SetNotFoundResponseError))
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
        public SetNotFoundResponseError Error { get; set; }

    }
}
