// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddAlertScheduler
    {
        /// <summary>
        /// Initializes a new instance of the AddAlertScheduler class.
        /// </summary>
        public AddAlertScheduler()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddAlertScheduler class.
        /// </summary>
        public AddAlertScheduler(System.DateTime? startTime = default(System.DateTime?), System.DateTime? lastExecutedTime = default(System.DateTime?), string periodMode = default(string), int? periodValue = default(int?), string timeZone = default(string))
        {
            StartTime = startTime;
            LastExecutedTime = lastExecutedTime;
            PeriodMode = periodMode;
            PeriodValue = periodValue;
            TimeZone = timeZone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastExecutedTime")]
        public System.DateTime? LastExecutedTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "periodMode")]
        public string PeriodMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "periodValue")]
        public int? PeriodValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PeriodValue != null)
            {
                if (PeriodValue < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "PeriodValue", 0);
                }
            }
        }
    }
}
