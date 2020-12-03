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

    public partial class AddAlertContextKpiMetadata
    {
        /// <summary>
        /// Initializes a new instance of the AddAlertContextKpiMetadata class.
        /// </summary>
        public AddAlertContextKpiMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddAlertContextKpiMetadata class.
        /// </summary>
        public AddAlertContextKpiMetadata(IList<AddAlertContextKpiMetadataMeasuresItem> measures, IList<AddAlertContextKpiMetadataFiltersItem> filters = default(IList<AddAlertContextKpiMetadataFiltersItem>))
        {
            Measures = measures;
            Filters = filters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "measures")]
        public IList<AddAlertContextKpiMetadataMeasuresItem> Measures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<AddAlertContextKpiMetadataFiltersItem> Filters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Measures == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Measures");
            }
            if (Measures != null)
            {
                if (Measures.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Measures", 1);
                }
                if (Measures.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Measures)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Measures");
                }
                foreach (var element in Measures)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Filters != null)
            {
                if (Filters.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Filters)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Filters");
                }
                foreach (var element1 in Filters)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}