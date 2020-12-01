// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// **Only applicable to `custom` type tables**
    /// </summary>
    public partial class TableOutputExpression
    {
        /// <summary>
        /// Initializes a new instance of the TableOutputExpression class.
        /// </summary>
        public TableOutputExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TableOutputExpression class.
        /// </summary>
        /// <param name="oid">Unique ID assigned to the expression
        /// Only used to track changes, any update of the expression will
        /// generate a new `oid` for it</param>
        /// <param name="expression">Actual SQL expression</param>
        /// <param name="lastUpdated">Datetime of most recent SQL expression
        /// change</param>
        public TableOutputExpression(System.Guid? oid = default(System.Guid?), string expression = default(string), System.DateTime? lastUpdated = default(System.DateTime?))
        {
            Oid = oid;
            Expression = expression;
            LastUpdated = lastUpdated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique ID assigned to the expression
        /// Only used to track changes, any update of the expression will
        /// generate a new `oid` for it
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public System.Guid? Oid { get; set; }

        /// <summary>
        /// Gets or sets actual SQL expression
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

        /// <summary>
        /// Gets or sets datetime of most recent SQL expression change
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Oid != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Oid.ToString(), "^[0-9a-f]{8}(-?[0-9a-f]{4}){3}-?[0-9a-f]{4,12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Oid", "^[0-9a-f]{8}(-?[0-9a-f]{4}){3}-?[0-9a-f]{4,12}$");
                }
            }
        }
    }
}
