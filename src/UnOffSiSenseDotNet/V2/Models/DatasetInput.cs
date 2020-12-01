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

    public partial class DatasetInput
    {
        /// <summary>
        /// Initializes a new instance of the DatasetInput class.
        /// </summary>
        public DatasetInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetInput class.
        /// </summary>
        /// <param name="name">Dataset name</param>
        /// <param name="type">Dataset type:
        ///
        /// - `live`: live connection dataset
        ///
        /// - `extract`: formerly known as 'Elasticube'
        ///
        /// - `custom` for custom SQL expression-based tables. Possible values
        /// include: 'live', 'extract', 'custom'</param>
        /// <param name="connection">Connection properties to data source - not
        /// applicable in `custom` type Datasets.
        ///
        /// As the properties for connections depend on the connector used, the
        /// specification here is only partial.
        ///
        /// Please refer to the online API refence for further information
        /// about available connectors.</param>
        public DatasetInput(string name, string type, ConnectionInput connection = default(ConnectionInput))
        {
            Name = name;
            Type = type;
            Connection = connection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dataset name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets dataset type:
        ///
        /// - `live`: live connection dataset
        ///
        /// - `extract`: formerly known as 'Elasticube'
        ///
        /// - `custom` for custom SQL expression-based tables. Possible values
        /// include: 'live', 'extract', 'custom'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets connection properties to data source - not applicable
        /// in `custom` type Datasets.
        ///
        /// As the properties for connections depend on the connector used, the
        /// specification here is only partial.
        ///
        /// Please refer to the online API refence for further information
        /// about available connectors.
        /// </summary>
        [JsonProperty(PropertyName = "connection")]
        public ConnectionInput Connection { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (Connection != null)
            {
                Connection.Validate();
            }
        }
    }
}
