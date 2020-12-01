// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UpdatableScopeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the UpdatableScopeConfiguration
        /// class.
        /// </summary>
        public UpdatableScopeConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdatableScopeConfiguration
        /// class.
        /// </summary>
        public UpdatableScopeConfiguration(string permissionType = default(string), IList<string> members = default(IList<string>))
        {
            PermissionType = permissionType;
            Members = members;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissionType")]
        public string PermissionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<string> Members { get; set; }

    }
}
