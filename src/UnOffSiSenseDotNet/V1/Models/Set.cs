// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Set
    {
        /// <summary>
        /// Initializes a new instance of the Set class.
        /// </summary>
        public Set()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Set class.
        /// </summary>
        public Set(string title = default(string), string routingMode = default(string), string failover = default(string), IList<string> fullNames = default(IList<string>))
        {
            Title = title;
            RoutingMode = routingMode;
            Failover = failover;
            FullNames = fullNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "routingMode")]
        public string RoutingMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failover")]
        public string Failover { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullNames")]
        public IList<string> FullNames { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Title != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Title, "^[^#]*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Title", "^[^#]*$");
                }
            }
        }
    }
}
