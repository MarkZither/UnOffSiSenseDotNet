// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddBadRequestResponse
    {
        /// <summary>
        /// Initializes a new instance of the AddBadRequestResponse class.
        /// </summary>
        public AddBadRequestResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddBadRequestResponse class.
        /// </summary>
        public AddBadRequestResponse(AddBadRequestResponseError error = default(AddBadRequestResponseError))
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
        public AddBadRequestResponseError Error { get; set; }

    }
}
