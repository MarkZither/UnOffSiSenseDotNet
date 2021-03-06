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
    /// Column
    /// </summary>
    public partial class Column
    {
        /// <summary>
        /// Initializes a new instance of the Column class.
        /// </summary>
        public Column()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Column class.
        /// </summary>
        public Column(bool? hidden = default(bool?), string id = default(string), bool? indexed = default(bool?), string name = default(string), string oid = default(string), int? precision = default(int?), int? scale = default(int?), int? size = default(int?), int? type = default(int?))
        {
            Hidden = hidden;
            Id = id;
            Indexed = indexed;
            Name = name;
            Oid = oid;
            Precision = precision;
            Scale = scale;
            Size = size;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "indexed")]
        public bool? Indexed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scale")]
        public int? Scale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

    }
}
