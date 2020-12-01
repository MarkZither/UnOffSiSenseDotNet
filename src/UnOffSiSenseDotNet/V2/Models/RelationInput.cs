// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class RelationInput
    {
        /// <summary>
        /// Initializes a new instance of the RelationInput class.
        /// </summary>
        public RelationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RelationInput class.
        /// </summary>
        /// <param name="columns">An array of columns by which their respective
        /// tables are connected</param>
        public RelationInput(IList<RelationFieldInput> columns)
        {
            Columns = columns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of columns by which their respective tables
        /// are connected
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<RelationFieldInput> Columns { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Columns == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Columns");
            }
            if (Columns != null)
            {
                foreach (var element in Columns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
