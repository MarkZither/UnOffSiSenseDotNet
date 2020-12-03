// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ServerDTO
    /// </summary>
    public partial class ServerDTO
    {
        /// <summary>
        /// Initializes a new instance of the ServerDTO class.
        /// </summary>
        public ServerDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerDTO class.
        /// </summary>
        /// <param name="permissionsSummary">Possible values include: 'NONE',
        /// 'ADMIN_ONLY', 'EVERYBODY', 'RESTRICTED'</param>
        public ServerDTO(string address = default(string), IList<CubeDTO> cubes = default(IList<CubeDTO>), IList<ACLDTO> defaultCubePermissions = default(IList<ACLDTO>), string errorMessage = default(string), string identity = default(string), string permissionsSummary = default(string))
        {
            Address = address;
            Cubes = cubes;
            DefaultCubePermissions = defaultCubePermissions;
            ErrorMessage = errorMessage;
            Identity = identity;
            PermissionsSummary = permissionsSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cubes")]
        public IList<CubeDTO> Cubes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultCubePermissions")]
        public IList<ACLDTO> DefaultCubePermissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public string Identity { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NONE', 'ADMIN_ONLY',
        /// 'EVERYBODY', 'RESTRICTED'
        /// </summary>
        [JsonProperty(PropertyName = "permissionsSummary")]
        public string PermissionsSummary { get; set; }

    }
}