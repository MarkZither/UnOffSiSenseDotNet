// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeleteManifestByPathOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the DeleteManifestByPathOKResponse
        /// class.
        /// </summary>
        public DeleteManifestByPathOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteManifestByPathOKResponse
        /// class.
        /// </summary>
        public DeleteManifestByPathOKResponse(string baseRoleName = default(string), string desc = default(string), DeleteManifestByPathOKResponseManifest manifest = default(DeleteManifestByPathOKResponseManifest), string name = default(string), string parent = default(string))
        {
            BaseRoleName = baseRoleName;
            Desc = desc;
            Manifest = manifest;
            Name = name;
            Parent = parent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseRoleName")]
        public string BaseRoleName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "manifest")]
        public DeleteManifestByPathOKResponseManifest Manifest { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent")]
        public string Parent { get; set; }

    }
}