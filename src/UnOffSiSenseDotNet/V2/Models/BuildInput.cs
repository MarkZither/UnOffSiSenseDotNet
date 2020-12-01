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

    public partial class BuildInput
    {
        /// <summary>
        /// Initializes a new instance of the BuildInput class.
        /// </summary>
        public BuildInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildInput class.
        /// </summary>
        /// <param name="datamodelId">Datamodel unique ID</param>
        /// <param name="buildType">Type of build performed. Possible values
        /// include: 'schema_changes', 'by_table', 'full', 'publish'</param>
        /// <param name="rowLimit">For `extract` type Datamodels, the maximum
        /// number of rows to import per table, if set.</param>
        public BuildInput(System.Guid datamodelId, string buildType, long? rowLimit = default(long?))
        {
            DatamodelId = datamodelId;
            BuildType = buildType;
            RowLimit = rowLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets datamodel unique ID
        /// </summary>
        [JsonProperty(PropertyName = "datamodelId")]
        public System.Guid DatamodelId { get; set; }

        /// <summary>
        /// Gets or sets type of build performed. Possible values include:
        /// 'schema_changes', 'by_table', 'full', 'publish'
        /// </summary>
        [JsonProperty(PropertyName = "buildType")]
        public string BuildType { get; set; }

        /// <summary>
        /// Gets or sets for `extract` type Datamodels, the maximum number of
        /// rows to import per table, if set.
        /// </summary>
        [JsonProperty(PropertyName = "rowLimit")]
        public long? RowLimit { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BuildType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BuildType");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(DatamodelId.ToString(), "^[0-9a-f]{8}(-?[0-9a-f]{4}){3}-?[0-9a-f]{4,12}$"))
            {
                throw new ValidationException(ValidationRules.Pattern, "DatamodelId", "^[0-9a-f]{8}(-?[0-9a-f]{4}){3}-?[0-9a-f]{4,12}$");
            }
        }
    }
}
