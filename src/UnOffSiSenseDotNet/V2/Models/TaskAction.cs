// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// TaskAction
    /// </summary>
    public partial class TaskAction
    {
        /// <summary>
        /// Initializes a new instance of the TaskAction class.
        /// </summary>
        public TaskAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskAction class.
        /// </summary>
        /// <param name="actionType">Possible values include: 'RestCommand',
        /// 'RabbitRPC'</param>
        public TaskAction(string actionType = default(string), RestCommand content = default(RestCommand))
        {
            ActionType = actionType;
            Content = content;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'RestCommand', 'RabbitRPC'
        /// </summary>
        [JsonProperty(PropertyName = "actionType")]
        public string ActionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public RestCommand Content { get; set; }

    }
}
