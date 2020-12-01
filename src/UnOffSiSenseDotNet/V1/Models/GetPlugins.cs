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

    /// <summary>
    /// Plugin response model
    /// </summary>
    public partial class GetPlugins
    {
        /// <summary>
        /// Initializes a new instance of the GetPlugins class.
        /// </summary>
        public GetPlugins()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetPlugins class.
        /// </summary>
        /// <param name="count">amount of plugins</param>
        public GetPlugins(IList<GetPluginsPluginsItem> plugins = default(IList<GetPluginsPluginsItem>), double? count = default(double?), GetPluginsQueryMetadata queryMetadata = default(GetPluginsQueryMetadata))
        {
            Plugins = plugins;
            Count = count;
            QueryMetadata = queryMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "plugins")]
        public IList<GetPluginsPluginsItem> Plugins { get; set; }

        /// <summary>
        /// Gets or sets amount of plugins
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryMetadata")]
        public GetPluginsQueryMetadata QueryMetadata { get; set; }

    }
}
