// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SimulateAddUsersItem
    {
        /// <summary>
        /// Initializes a new instance of the SimulateAddUsersItem class.
        /// </summary>
        public SimulateAddUsersItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimulateAddUsersItem class.
        /// </summary>
        public SimulateAddUsersItem(string email = default(string), bool? isExist = default(bool?), string roleId = default(string))
        {
            Email = email;
            IsExist = isExist;
            RoleId = roleId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isExist")]
        public bool? IsExist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleId")]
        public string RoleId { get; set; }

    }
}
