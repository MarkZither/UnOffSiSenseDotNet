// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatchPivotSettingsForbiddenResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PatchPivotSettingsForbiddenResponse class.
        /// </summary>
        public PatchPivotSettingsForbiddenResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PatchPivotSettingsForbiddenResponse class.
        /// </summary>
        public PatchPivotSettingsForbiddenResponse(PatchPivotSettingsForbiddenResponseError error = default(PatchPivotSettingsForbiddenResponseError))
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
        public PatchPivotSettingsForbiddenResponseError Error { get; set; }

    }
}
