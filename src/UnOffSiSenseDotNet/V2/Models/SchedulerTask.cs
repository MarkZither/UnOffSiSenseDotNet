// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SchedulerTask
    /// </summary>
    public partial class SchedulerTask
    {
        /// <summary>
        /// Initializes a new instance of the SchedulerTask class.
        /// </summary>
        public SchedulerTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchedulerTask class.
        /// </summary>
        public SchedulerTask(TaskAction action, bool? active = default(bool?), string explicitTime = default(string), string externalId = default(string), string id = default(string), IList<CronUTC> schedules = default(IList<CronUTC>))
        {
            Action = action;
            Active = active;
            ExplicitTime = explicitTime;
            ExternalId = externalId;
            Id = id;
            Schedules = schedules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public TaskAction Action { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "explicitTime")]
        public string ExplicitTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedules")]
        public IList<CronUTC> Schedules { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Action == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Action");
            }
        }
    }
}
