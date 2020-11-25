// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Dashboard
    {
        /// <summary>
        /// Initializes a new instance of the Dashboard class.
        /// </summary>
        public Dashboard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dashboard class.
        /// </summary>
        public Dashboard(string _id = default(string), System.DateTime? created = default(System.DateTime?), string desc = default(string), System.DateTime? lastUpdated = default(System.DateTime?), System.DateTime? lastUsed = default(System.DateTime?), string layout = default(string), string oid = default(string), string owner = default(string), string parentFolder = default(string), IList<SharesToObject> shares = default(IList<SharesToObject>), string source = default(string), string style = default(string), IList<object> tags = default(IList<object>), string type = default(string), int? usageCount = default(int?), string userId = default(string))
        {
            this._id = _id;
            Created = created;
            Desc = desc;
            LastUpdated = lastUpdated;
            LastUsed = lastUsed;
            Layout = layout;
            Oid = oid;
            Owner = owner;
            ParentFolder = parentFolder;
            Shares = shares;
            Source = source;
            Style = style;
            Tags = tags;
            Type = type;
            UsageCount = usageCount;
            UserId = userId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUsed")]
        public System.DateTime? LastUsed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "layout")]
        public string Layout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentFolder")]
        public string ParentFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares")]
        public IList<SharesToObject> Shares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "style")]
        public string Style { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<object> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "usageCount")]
        public int? UsageCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

    }
}
