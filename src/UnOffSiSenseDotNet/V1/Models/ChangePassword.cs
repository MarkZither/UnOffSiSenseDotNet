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

    public partial class ChangePassword
    {
        /// <summary>
        /// Initializes a new instance of the ChangePassword class.
        /// </summary>
        public ChangePassword()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangePassword class.
        /// </summary>
        public ChangePassword(string currentPassword, string newPassword)
        {
            CurrentPassword = currentPassword;
            NewPassword = newPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentPassword")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CurrentPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrentPassword");
            }
            if (NewPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NewPassword");
            }
        }
    }
}