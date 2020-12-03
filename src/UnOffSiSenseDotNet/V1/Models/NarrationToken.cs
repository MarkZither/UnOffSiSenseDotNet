// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NarrationToken
    {
        /// <summary>
        /// Initializes a new instance of the NarrationToken class.
        /// </summary>
        public NarrationToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NarrationToken class.
        /// </summary>
        /// <param name="narrationTokenProperty">narration provider
        /// token.</param>
        public NarrationToken(string narrationTokenProperty = default(string))
        {
            NarrationTokenProperty = narrationTokenProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets narration provider token.
        /// </summary>
        [JsonProperty(PropertyName = "narrationToken")]
        public string NarrationTokenProperty { get; set; }

    }
}