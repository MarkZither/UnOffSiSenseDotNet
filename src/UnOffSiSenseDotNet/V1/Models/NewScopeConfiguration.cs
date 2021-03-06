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

    public partial class NewScopeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the NewScopeConfiguration class.
        /// </summary>
        public NewScopeConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NewScopeConfiguration class.
        /// </summary>
        public NewScopeConfiguration(string column = default(string), string table = default(string), string permissionType = default(string), IList<string> members = default(IList<string>))
        {
            Column = column;
            Table = table;
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
        [JsonProperty(PropertyName = "column")]
        public string Column { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

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
