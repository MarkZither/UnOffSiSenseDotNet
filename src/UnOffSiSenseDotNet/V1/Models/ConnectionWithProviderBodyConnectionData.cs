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

    public partial class ConnectionWithProviderBodyConnectionData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionWithProviderBodyConnectionData class.
        /// </summary>
        public ConnectionWithProviderBodyConnectionData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionWithProviderBodyConnectionData class.
        /// </summary>
        /// <param name="connection">Key value pairs of connection properties
        /// for specific connector. Values **must** be strings or array of
        /// strings.</param>
        /// <param name="schema">Database schema</param>
        /// <param name="table">Table name</param>
        /// <param name="fetchRelations">Used in schema details api. Tells api
        /// to return table relations next to columns</param>
        public ConnectionWithProviderBodyConnectionData(object connection, string schema = default(string), string table = default(string), double? limit = default(double?), bool? fetchRelations = default(bool?), string sql = default(string))
        {
            Connection = connection;
            Schema = schema;
            Table = table;
            Limit = limit;
            FetchRelations = fetchRelations;
            Sql = sql;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key value pairs of connection properties for specific
        /// connector. Values **must** be strings or array of strings.
        /// </summary>
        [JsonProperty(PropertyName = "connection")]
        public object Connection { get; set; }

        /// <summary>
        /// Gets or sets database schema
        /// </summary>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets table name
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Gets or sets used in schema details api. Tells api to return table
        /// relations next to columns
        /// </summary>
        [JsonProperty(PropertyName = "fetchRelations")]
        public bool? FetchRelations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sql")]
        public string Sql { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Connection == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Connection");
            }
        }
    }
}
