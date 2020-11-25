// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InfoResponse
    /// </summary>
    public partial class InfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the InfoResponse class.
        /// </summary>
        public InfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InfoResponse class.
        /// </summary>
        /// <param name="status">Possible values include: 'OK',
        /// 'FAILED'</param>
        public InfoResponse(IList<CubeInfoItem> cubes = default(IList<CubeInfoItem>), string status = default(string))
        {
            Cubes = cubes;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cubes")]
        public IList<CubeInfoItem> Cubes { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OK', 'FAILED'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}
