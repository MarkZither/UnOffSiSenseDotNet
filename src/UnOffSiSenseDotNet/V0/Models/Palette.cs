// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Palette
    {
        /// <summary>
        /// Initializes a new instance of the Palette class.
        /// </summary>
        public Palette()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Palette class.
        /// </summary>
        public Palette(IList<string> colors, string name, string _id = default(string), bool? isDefault = default(bool?), string max = default(string), string min = default(string), int? sortOrder = default(int?))
        {
            this._id = _id;
            Colors = colors;
            IsDefault = isDefault;
            Max = max;
            Min = min;
            Name = name;
            SortOrder = sortOrder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "colors")]
        public IList<string> Colors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public string Max { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public string Min { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Colors == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Colors");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
