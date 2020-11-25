// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Subscription
    {
        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public Subscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        /// <param name="jobType">Possible values include:
        /// 'subscription'</param>
        public Subscription(string _id = default(string), bool? active = default(bool?), string context = default(string), System.DateTime? created = default(System.DateTime?), bool? isDataChange = default(bool?), string jobType = default(string), System.DateTime? lastExecution = default(System.DateTime?), System.DateTime? lastUpdated = default(System.DateTime?), string owner = default(string), string schedule = default(string), System.DateTime? startAt = default(System.DateTime?), string timezone = default(string))
        {
            this._id = _id;
            Active = active;
            Context = context;
            Created = created;
            IsDataChange = isDataChange;
            JobType = jobType;
            LastExecution = lastExecution;
            LastUpdated = lastUpdated;
            Owner = owner;
            Schedule = schedule;
            StartAt = startAt;
            Timezone = timezone;
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
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDataChange")]
        public bool? IsDataChange { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'subscription'
        /// </summary>
        [JsonProperty(PropertyName = "jobType")]
        public string JobType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastExecution")]
        public System.DateTime? LastExecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startAt")]
        public System.DateTime? StartAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

    }
}
