// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UpdateAlertAction
    {
        /// <summary>
        /// Initializes a new instance of the UpdateAlertAction class.
        /// </summary>
        public UpdateAlertAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateAlertAction class.
        /// </summary>
        public UpdateAlertAction(bool? email = default(bool?), bool? mobile = default(bool?), bool? feed = default(bool?), UpdateAlertActionSlack slack = default(UpdateAlertActionSlack), UpdateAlertActionZapier zapier = default(UpdateAlertActionZapier), IList<UpdateAlertActionWebhooksItem> webhooks = default(IList<UpdateAlertActionWebhooksItem>))
        {
            Email = email;
            Mobile = mobile;
            Feed = feed;
            Slack = slack;
            Zapier = zapier;
            Webhooks = webhooks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public bool? Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobile")]
        public bool? Mobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feed")]
        public bool? Feed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slack")]
        public UpdateAlertActionSlack Slack { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "zapier")]
        public UpdateAlertActionZapier Zapier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webhooks")]
        public IList<UpdateAlertActionWebhooksItem> Webhooks { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Slack != null)
            {
                Slack.Validate();
            }
            if (Zapier != null)
            {
                Zapier.Validate();
            }
            if (Webhooks != null)
            {
                foreach (var element in Webhooks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
