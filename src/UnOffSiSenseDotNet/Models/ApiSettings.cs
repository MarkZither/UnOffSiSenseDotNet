// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiSettings
    {
        /// <summary>
        /// Initializes a new instance of the ApiSettings class.
        /// </summary>
        public ApiSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiSettings class.
        /// </summary>
        public ApiSettings(string _id = default(string), string apiKey = default(string))
        {
            this._id = _id;
            ApiKey = apiKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiKey")]
        public string ApiKey { get; set; }

    }
}
