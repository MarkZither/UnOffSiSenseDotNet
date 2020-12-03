// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DeploymentServiceResponseListNodeWithSpec
    /// </summary>
    public partial class DeploymentServiceResponseListNodeWithSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DeploymentServiceResponseListNodeWithSpec class.
        /// </summary>
        public DeploymentServiceResponseListNodeWithSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DeploymentServiceResponseListNodeWithSpec class.
        /// </summary>
        /// <param name="status">Possible values include: 'OK',
        /// 'INTERNAL_ERROR', 'NODE_NOT_FOUND', 'NODE_ALREADY_EXISTS',
        /// 'UNAUTHORIZED'</param>
        public DeploymentServiceResponseListNodeWithSpec(string error = default(string), string status = default(string), int? statusCode = default(int?), IList<NodeWithSpec> value = default(IList<NodeWithSpec>))
        {
            Error = error;
            Status = status;
            StatusCode = statusCode;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OK', 'INTERNAL_ERROR',
        /// 'NODE_NOT_FOUND', 'NODE_ALREADY_EXISTS', 'UNAUTHORIZED'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<NodeWithSpec> Value { get; set; }

    }
}