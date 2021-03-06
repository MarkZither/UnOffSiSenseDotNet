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

    public partial class CopyRequestDashboardsItem
    {
        /// <summary>
        /// Initializes a new instance of the CopyRequestDashboardsItem class.
        /// </summary>
        public CopyRequestDashboardsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CopyRequestDashboardsItem class.
        /// </summary>
        /// <param name="action">Possible values include: 'duplicate',
        /// 'overwrite', 'skip'</param>
        public CopyRequestDashboardsItem(string id = default(string), string action = default(string))
        {
            Id = id;
            Action = action;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'duplicate', 'overwrite',
        /// 'skip'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Id, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Id", "^[0-9a-fA-F]{24}$");
                }
            }
        }
    }
}
