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
    /// NodeUpdateParams
    /// </summary>
    public partial class NodeUpdateParams
    {
        /// <summary>
        /// Initializes a new instance of the NodeUpdateParams class.
        /// </summary>
        public NodeUpdateParams()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeUpdateParams class.
        /// </summary>
        public NodeUpdateParams(IList<string> nodeRoles = default(IList<string>))
        {
            NodeRoles = nodeRoles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nodeRoles")]
        public IList<string> NodeRoles { get; set; }

    }
}
