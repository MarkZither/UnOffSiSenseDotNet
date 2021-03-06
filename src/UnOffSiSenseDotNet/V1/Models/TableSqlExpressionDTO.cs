// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TableSqlExpressionDTO
    /// </summary>
    public partial class TableSqlExpressionDTO
    {
        /// <summary>
        /// Initializes a new instance of the TableSqlExpressionDTO class.
        /// </summary>
        public TableSqlExpressionDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TableSqlExpressionDTO class.
        /// </summary>
        public TableSqlExpressionDTO(int? column = default(int?), ContextDTO context = default(ContextDTO), string expression = default(string), int? row = default(int?))
        {
            Column = column;
            Context = context;
            Expression = expression;
            Row = row;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public int? Column { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public ContextDTO Context { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expression")]
        public string Expression { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "row")]
        public int? Row { get; set; }

    }
}
