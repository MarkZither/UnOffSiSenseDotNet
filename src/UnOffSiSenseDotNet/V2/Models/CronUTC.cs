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
    /// CronUTC
    /// </summary>
    public partial class CronUTC
    {
        /// <summary>
        /// Initializes a new instance of the CronUTC class.
        /// </summary>
        public CronUTC()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CronUTC class.
        /// </summary>
        public CronUTC(bool? active = default(bool?), string cron = default(string))
        {
            Active = active;
            Cron = cron;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cron")]
        public string Cron { get; set; }

    }
}
