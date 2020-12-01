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

    public partial class ExtendedAllDashboardsQueryOptions
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedAllDashboardsQueryOptions
        /// class.
        /// </summary>
        public ExtendedAllDashboardsQueryOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedAllDashboardsQueryOptions
        /// class.
        /// </summary>
        public ExtendedAllDashboardsQueryOptions(string fields = default(string), object sort = default(object), int? skip = default(int?), int? limit = default(int?))
        {
            Fields = fields;
            Sort = sort;
            Skip = skip;
            Limit = limit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public string Fields { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sort")]
        public object Sort { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public int? Skip { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Skip != null)
            {
                if (Skip < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Skip", 0);
                }
            }
            if (Limit != null)
            {
                if (Limit < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Limit", 1);
                }
            }
        }
    }
}
