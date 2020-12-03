// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// QoS configuration for Query Nodes in the Data Group
    /// </summary>
    public partial class DataGroupInputQueryQualityOfService
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataGroupInputQueryQualityOfService class.
        /// </summary>
        public DataGroupInputQueryQualityOfService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataGroupInputQueryQualityOfService class.
        /// </summary>
        /// <param name="queryTimeout">Query timeout in Seconds</param>
        /// <param name="concurrentQueries">Maximum concurrent queries per
        /// Datamodel in the Data Group</param>
        /// <param name="replicaScaleMax">Maximum physical instances per
        /// Datamodel in the Data Group</param>
        /// <param name="replicaScaleMin">Minimum physical instances per
        /// Datamodel in the Data Group</param>
        public DataGroupInputQueryQualityOfService(int? queryTimeout = default(int?), int? concurrentQueries = default(int?), int? replicaScaleMax = default(int?), int? replicaScaleMin = default(int?))
        {
            QueryTimeout = queryTimeout;
            ConcurrentQueries = concurrentQueries;
            ReplicaScaleMax = replicaScaleMax;
            ReplicaScaleMin = replicaScaleMin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets query timeout in Seconds
        /// </summary>
        [JsonProperty(PropertyName = "queryTimeout")]
        public int? QueryTimeout { get; set; }

        /// <summary>
        /// Gets or sets maximum concurrent queries per Datamodel in the Data
        /// Group
        /// </summary>
        [JsonProperty(PropertyName = "concurrentQueries")]
        public int? ConcurrentQueries { get; set; }

        /// <summary>
        /// Gets or sets maximum physical instances per Datamodel in the Data
        /// Group
        /// </summary>
        [JsonProperty(PropertyName = "replicaScaleMax")]
        public int? ReplicaScaleMax { get; set; }

        /// <summary>
        /// Gets or sets minimum physical instances per Datamodel in the Data
        /// Group
        /// </summary>
        [JsonProperty(PropertyName = "replicaScaleMin")]
        public int? ReplicaScaleMin { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (QueryTimeout != null)
            {
                if (QueryTimeout < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "QueryTimeout", 1);
                }
            }
            if (ConcurrentQueries != null)
            {
                if (ConcurrentQueries < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ConcurrentQueries", 1);
                }
            }
            if (ReplicaScaleMax != null)
            {
                if (ReplicaScaleMax < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ReplicaScaleMax", 1);
                }
            }
            if (ReplicaScaleMin != null)
            {
                if (ReplicaScaleMin < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "ReplicaScaleMin", 1);
                }
            }
        }
    }
}