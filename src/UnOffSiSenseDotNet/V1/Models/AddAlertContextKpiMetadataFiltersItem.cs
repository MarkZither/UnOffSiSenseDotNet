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

    public partial class AddAlertContextKpiMetadataFiltersItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AddAlertContextKpiMetadataFiltersItem class.
        /// </summary>
        public AddAlertContextKpiMetadataFiltersItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AddAlertContextKpiMetadataFiltersItem class.
        /// </summary>
        /// <param name="panel">Possible values include: 'scope'</param>
        public AddAlertContextKpiMetadataFiltersItem(object jaql, string panel = default(string))
        {
            Jaql = jaql;
            Panel = panel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jaql")]
        public object Jaql { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'scope'
        /// </summary>
        [JsonProperty(PropertyName = "panel")]
        public string Panel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Jaql == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Jaql");
            }
        }
    }
}
