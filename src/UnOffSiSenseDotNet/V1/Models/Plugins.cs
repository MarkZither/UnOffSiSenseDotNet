// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Plugin object
    /// </summary>
    public partial class Plugins
    {
        /// <summary>
        /// Initializes a new instance of the Plugins class.
        /// </summary>
        public Plugins()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Plugins class.
        /// </summary>
        /// <param name="name">plugin name</param>
        /// <param name="version">version of plugin</param>
        /// <param name="lastUpdate">last time plugin updated</param>
        /// <param name="isEnabled">enabled/disabled plugin status</param>
        /// <param name="folderName">plugin folder name</param>
        public Plugins(string name = default(string), string version = default(string), string lastUpdate = default(string), bool? isEnabled = default(bool?), string folderName = default(string))
        {
            Name = name;
            Version = version;
            LastUpdate = lastUpdate;
            IsEnabled = isEnabled;
            FolderName = folderName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets plugin name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets version of plugin
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets last time plugin updated
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdate")]
        public string LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets enabled/disabled plugin status
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets plugin folder name
        /// </summary>
        [JsonProperty(PropertyName = "folderName")]
        public string FolderName { get; set; }

    }
}