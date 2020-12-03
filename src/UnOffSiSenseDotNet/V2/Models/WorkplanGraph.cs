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

    /// <summary>
    /// WorkplanGraph
    /// </summary>
    public partial class WorkplanGraph
    {
        /// <summary>
        /// Initializes a new instance of the WorkplanGraph class.
        /// </summary>
        public WorkplanGraph()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkplanGraph class.
        /// </summary>
        /// <param name="nodes">Workplan graph's nodes list</param>
        /// <param name="edges">Workplan graph's edges list</param>
        public WorkplanGraph(IList<WorkplanNodeStatus> nodes, IList<WorkplanEdge> edges)
        {
            Nodes = nodes;
            Edges = edges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets workplan graph's nodes list
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<WorkplanNodeStatus> Nodes { get; set; }

        /// <summary>
        /// Gets or sets workplan graph's edges list
        /// </summary>
        [JsonProperty(PropertyName = "edges")]
        public IList<WorkplanEdge> Edges { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Nodes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Nodes");
            }
            if (Edges == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Edges");
            }
            if (Nodes != null)
            {
                foreach (var element in Nodes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Edges != null)
            {
                foreach (var element1 in Edges)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}