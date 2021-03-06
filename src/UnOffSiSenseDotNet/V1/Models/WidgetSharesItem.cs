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

    public partial class WidgetSharesItem
    {
        /// <summary>
        /// Initializes a new instance of the WidgetSharesItem class.
        /// </summary>
        public WidgetSharesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WidgetSharesItem class.
        /// </summary>
        /// <param name="type">Possible values include: 'user', 'group'</param>
        /// <param name="rule">Possible values include: 'view', 'edit'</param>
        public WidgetSharesItem(string shareId, string type, string rule = default(string), bool? subscribe = default(bool?))
        {
            ShareId = shareId;
            Type = type;
            Rule = rule;
            Subscribe = subscribe;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shareId")]
        public string ShareId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'user', 'group'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'view', 'edit'
        /// </summary>
        [JsonProperty(PropertyName = "rule")]
        public string Rule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribe")]
        public bool? Subscribe { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShareId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShareId");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (ShareId != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(ShareId, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ShareId", "^[0-9a-fA-F]{24}$");
                }
            }
        }
    }
}
