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
    /// Expression
    /// </summary>
    public partial class Expression
    {
        /// <summary>
        /// Initializes a new instance of the Expression class.
        /// </summary>
        public Expression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Expression class.
        /// </summary>
        public Expression(string expressionProperty = default(string), string lastUpdated = default(string), string oid = default(string))
        {
            ExpressionProperty = expressionProperty;
            LastUpdated = lastUpdated;
            Oid = oid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string ExpressionProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

    }
}
