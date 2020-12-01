// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BuildScheduleInput
    {
        /// <summary>
        /// Initializes a new instance of the BuildScheduleInput class.
        /// </summary>
        public BuildScheduleInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildScheduleInput class.
        /// </summary>
        /// <param name="buildType">What type of build to execute
        /// `live` Datamodels can only use `publish`. Possible values include:
        /// 'schema-changes', 'by-table', 'full', 'publish'</param>
        /// <param name="daysOfWeek">For `dow` type schedule, which days of the
        /// week build should be run</param>
        /// <param name="hour">For `dow` type schedule, which hour of the day
        /// build should be run</param>
        /// <param name="intervalSeconds">For `interval` type schedule,
        /// interval in seconds that build should be run on</param>
        /// <param name="minute">For `dow` type schedule, which minute of the
        /// hour build should be run</param>
        /// <param name="cron">For `cron` type schedule, the `CRON`
        /// expression</param>
        /// <param name="scheduleType">Possible values include: 'interval',
        /// 'dow', 'cron'</param>
        public BuildScheduleInput(string buildType = default(string), IList<string> daysOfWeek = default(IList<string>), int? hour = default(int?), long? intervalSeconds = default(long?), int? minute = default(int?), string cron = default(string), string scheduleType = default(string))
        {
            BuildType = buildType;
            DaysOfWeek = daysOfWeek;
            Hour = hour;
            IntervalSeconds = intervalSeconds;
            Minute = minute;
            Cron = cron;
            ScheduleType = scheduleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets what type of build to execute
        /// `live` Datamodels can only use `publish`. Possible values include:
        /// 'schema-changes', 'by-table', 'full', 'publish'
        /// </summary>
        [JsonProperty(PropertyName = "buildType")]
        public string BuildType { get; set; }

        /// <summary>
        /// Gets or sets for `dow` type schedule, which days of the week build
        /// should be run
        /// </summary>
        [JsonProperty(PropertyName = "daysOfWeek")]
        public IList<string> DaysOfWeek { get; set; }

        /// <summary>
        /// Gets or sets for `dow` type schedule, which hour of the day build
        /// should be run
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// Gets or sets for `interval` type schedule, interval in seconds that
        /// build should be run on
        /// </summary>
        [JsonProperty(PropertyName = "intervalSeconds")]
        public long? IntervalSeconds { get; set; }

        /// <summary>
        /// Gets or sets for `dow` type schedule, which minute of the hour
        /// build should be run
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public int? Minute { get; set; }

        /// <summary>
        /// Gets or sets for `cron` type schedule, the `CRON` expression
        /// </summary>
        [JsonProperty(PropertyName = "cron")]
        public string Cron { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'interval', 'dow', 'cron'
        /// </summary>
        [JsonProperty(PropertyName = "scheduleType")]
        public string ScheduleType { get; set; }

    }
}
