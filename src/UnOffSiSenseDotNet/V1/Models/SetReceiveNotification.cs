// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetReceiveNotification
    {
        /// <summary>
        /// Initializes a new instance of the SetReceiveNotification class.
        /// </summary>
        public SetReceiveNotification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetReceiveNotification class.
        /// </summary>
        public SetReceiveNotification(bool receiveNotification)
        {
            ReceiveNotification = receiveNotification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receiveNotification")]
        public bool ReceiveNotification { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
