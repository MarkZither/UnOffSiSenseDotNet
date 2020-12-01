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

    /// <summary>
    /// Throwable
    /// </summary>
    public partial class Throwable
    {
        /// <summary>
        /// Initializes a new instance of the Throwable class.
        /// </summary>
        public Throwable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Throwable class.
        /// </summary>
        public Throwable(Throwable cause = default(Throwable), string localizedMessage = default(string), string message = default(string), IList<StackTraceElement> stackTrace = default(IList<StackTraceElement>), IList<Throwable> suppressed = default(IList<Throwable>))
        {
            Cause = cause;
            LocalizedMessage = localizedMessage;
            Message = message;
            StackTrace = stackTrace;
            Suppressed = suppressed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cause")]
        public Throwable Cause { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "localizedMessage")]
        public string LocalizedMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stackTrace")]
        public IList<StackTraceElement> StackTrace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "suppressed")]
        public IList<Throwable> Suppressed { get; set; }

    }
}
