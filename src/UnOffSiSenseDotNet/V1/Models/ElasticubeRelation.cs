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

    public partial class ElasticubeRelation
    {
        /// <summary>
        /// Initializes a new instance of the ElasticubeRelation class.
        /// </summary>
        public ElasticubeRelation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticubeRelation class.
        /// </summary>
        public ElasticubeRelation(System.Guid? elasticube = default(System.Guid?), System.Guid? oid = default(System.Guid?), IList<ElasticubeRelationColumnsItem> columns = default(IList<ElasticubeRelationColumnsItem>), string lastUpdated = default(string))
        {
            Elasticube = elasticube;
            Oid = oid;
            Columns = columns;
            LastUpdated = lastUpdated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "elasticube")]
        public System.Guid? Elasticube { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public System.Guid? Oid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<ElasticubeRelationColumnsItem> Columns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public string LastUpdated { get; set; }

    }
}