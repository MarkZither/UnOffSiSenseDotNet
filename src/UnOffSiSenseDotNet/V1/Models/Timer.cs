// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Timer
    {
        /// <summary>
        /// Initializes a new instance of the Timer class.
        /// </summary>
        public Timer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Timer class.
        /// </summary>
        /// <param name="dashboard">Dashboard object</param>
        public Timer(TimerDashboard dashboard = default(TimerDashboard))
        {
            Dashboard = dashboard;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dashboard object
        /// </summary>
        [JsonProperty(PropertyName = "dashboard")]
        public TimerDashboard Dashboard { get; set; }

    }
}
