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
    /// Relation
    /// </summary>
    public partial class Relation
    {
        /// <summary>
        /// Initializes a new instance of the Relation class.
        /// </summary>
        public Relation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Relation class.
        /// </summary>
        public Relation(IList<ColumnsRef> columns = default(IList<ColumnsRef>), string oid = default(string))
        {
            Columns = columns;
            Oid = oid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<ColumnsRef> Columns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

    }
}
