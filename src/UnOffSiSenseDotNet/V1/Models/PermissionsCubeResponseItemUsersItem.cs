// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PermissionsCubeResponseItemUsersItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PermissionsCubeResponseItemUsersItem class.
        /// </summary>
        public PermissionsCubeResponseItemUsersItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PermissionsCubeResponseItemUsersItem class.
        /// </summary>
        public PermissionsCubeResponseItemUsersItem(string id = default(string), bool? accessAllowed = default(bool?), string email = default(string))
        {
            Id = id;
            AccessAllowed = accessAllowed;
            Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessAllowed")]
        public bool? AccessAllowed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

    }
}
