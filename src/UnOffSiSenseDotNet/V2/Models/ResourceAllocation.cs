// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ResourceAllocation
    /// </summary>
    public partial class ResourceAllocation
    {
        /// <summary>
        /// Initializes a new instance of the ResourceAllocation class.
        /// </summary>
        public ResourceAllocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceAllocation class.
        /// </summary>
        public ResourceAllocation(int? coresUsagePercentage = default(int?), double? limitCpuCores = default(double?), int? limitRamSizeInMB = default(int?), double? requiredCpuCores = default(double?), int? requiredRamSizeInMB = default(int?))
        {
            CoresUsagePercentage = coresUsagePercentage;
            LimitCpuCores = limitCpuCores;
            LimitRamSizeInMB = limitRamSizeInMB;
            RequiredCpuCores = requiredCpuCores;
            RequiredRamSizeInMB = requiredRamSizeInMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coresUsagePercentage")]
        public int? CoresUsagePercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "limitCpuCores")]
        public double? LimitCpuCores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "limitRamSizeInMB")]
        public int? LimitRamSizeInMB { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredCpuCores")]
        public double? RequiredCpuCores { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredRamSizeInMB")]
        public int? RequiredRamSizeInMB { get; set; }

    }
}
