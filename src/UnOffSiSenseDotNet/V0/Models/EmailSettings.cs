// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EmailSettings
    {
        /// <summary>
        /// Initializes a new instance of the EmailSettings class.
        /// </summary>
        public EmailSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailSettings class.
        /// </summary>
        public EmailSettings(bool? isEmail = default(bool?), bool? isPdf = default(bool?))
        {
            IsEmail = isEmail;
            IsPdf = isPdf;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isEmail")]
        public bool? IsEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPdf")]
        public bool? IsPdf { get; set; }

    }
}