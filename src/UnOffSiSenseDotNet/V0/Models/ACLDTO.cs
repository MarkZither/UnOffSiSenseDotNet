// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ACLDTO
    /// </summary>
    public partial class ACLDTO
    {
        /// <summary>
        /// Initializes a new instance of the ACLDTO class.
        /// </summary>
        public ACLDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ACLDTO class.
        /// </summary>
        public ACLDTO(bool? belongsToEveryoneGroup = default(bool?), string party = default(string), string partyId = default(string), string permission = default(string), string type = default(string))
        {
            BelongsToEveryoneGroup = belongsToEveryoneGroup;
            Party = party;
            PartyId = partyId;
            Permission = permission;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "belongsToEveryoneGroup")]
        public bool? BelongsToEveryoneGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "party")]
        public string Party { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "partyId")]
        public string PartyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
