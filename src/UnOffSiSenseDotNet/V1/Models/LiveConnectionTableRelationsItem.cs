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

    public partial class LiveConnectionTableRelationsItem
    {
        /// <summary>
        /// Initializes a new instance of the LiveConnectionTableRelationsItem
        /// class.
        /// </summary>
        public LiveConnectionTableRelationsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveConnectionTableRelationsItem
        /// class.
        /// </summary>
        public LiveConnectionTableRelationsItem(string fkName = default(string), string parentSchema = default(string), string parentTable = default(string), IList<string> parentColumns = default(IList<string>), string childSchema = default(string), string childTable = default(string), IList<string> childColumns = default(IList<string>))
        {
            FkName = fkName;
            ParentSchema = parentSchema;
            ParentTable = parentTable;
            ParentColumns = parentColumns;
            ChildSchema = childSchema;
            ChildTable = childTable;
            ChildColumns = childColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fkName")]
        public string FkName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentSchema")]
        public string ParentSchema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentTable")]
        public string ParentTable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentColumns")]
        public IList<string> ParentColumns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childSchema")]
        public string ChildSchema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childTable")]
        public string ChildTable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "childColumns")]
        public IList<string> ChildColumns { get; set; }

    }
}
