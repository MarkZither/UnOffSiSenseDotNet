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

    public partial class EventBy
    {
        /// <summary>
        /// Initializes a new instance of the EventBy class.
        /// </summary>
        public EventBy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventBy class.
        /// </summary>
        /// <param name="type">Possible values include: 'dashboard', 'cube',
        /// 'server'</param>
        public EventBy(string type, string name = default(string), string oid = default(string))
        {
            Name = name;
            Oid = oid;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'dashboard', 'cube', 'server'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Oid != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Oid, "^[0-9a-fA-F]{24}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Oid", "^[0-9a-fA-F]{24}$");
                }
            }
        }
    }
}
