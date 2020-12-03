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

    public partial class SimulateAdd
    {
        /// <summary>
        /// Initializes a new instance of the SimulateAdd class.
        /// </summary>
        public SimulateAdd()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimulateAdd class.
        /// </summary>
        public SimulateAdd(SimulateAddLicense license = default(SimulateAddLicense), IList<SimulateAddUsersItem> users = default(IList<SimulateAddUsersItem>))
        {
            License = license;
            Users = users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "license")]
        public SimulateAddLicense License { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<SimulateAddUsersItem> Users { get; set; }

    }
}