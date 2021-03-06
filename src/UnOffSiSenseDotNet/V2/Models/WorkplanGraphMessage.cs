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
    /// WorkplanGraphMessage
    /// </summary>
    public partial class WorkplanGraphMessage
    {
        /// <summary>
        /// Initializes a new instance of the WorkplanGraphMessage class.
        /// </summary>
        public WorkplanGraphMessage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkplanGraphMessage class.
        /// </summary>
        /// <param name="workplanId">Workplan's unique ID</param>
        /// <param name="timestamp">Message timestamp</param>
        /// <param name="type">Message type. Possible values include:
        /// 'WORKPLAN_EXPLAIN_GRAPH', 'WORKPLAN_EXPLAIN_UPDATE'</param>
        /// <param name="workplanStatus">Workplan status</param>
        /// <param name="graph">Workplan graph, represents the tasks' nodes and
        /// the edges (dependencies) between them</param>
        public WorkplanGraphMessage(string workplanId, string timestamp, string type, WorkplanStatus workplanStatus, WorkplanGraph graph)
        {
            WorkplanId = workplanId;
            Timestamp = timestamp;
            Type = type;
            WorkplanStatus = workplanStatus;
            Graph = graph;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets workplan's unique ID
        /// </summary>
        [JsonProperty(PropertyName = "workplanId")]
        public string WorkplanId { get; set; }

        /// <summary>
        /// Gets or sets message timestamp
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or sets message type. Possible values include:
        /// 'WORKPLAN_EXPLAIN_GRAPH', 'WORKPLAN_EXPLAIN_UPDATE'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets workplan status
        /// </summary>
        [JsonProperty(PropertyName = "workplanStatus")]
        public WorkplanStatus WorkplanStatus { get; set; }

        /// <summary>
        /// Gets or sets workplan graph, represents the tasks' nodes and the
        /// edges (dependencies) between them
        /// </summary>
        [JsonProperty(PropertyName = "graph")]
        public WorkplanGraph Graph { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WorkplanId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkplanId");
            }
            if (Timestamp == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Timestamp");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (WorkplanStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkplanStatus");
            }
            if (Graph == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Graph");
            }
            if (WorkplanStatus != null)
            {
                WorkplanStatus.Validate();
            }
            if (Graph != null)
            {
                Graph.Validate();
            }
        }
    }
}
