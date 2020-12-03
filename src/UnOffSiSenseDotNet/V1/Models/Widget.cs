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

    public partial class Widget
    {
        /// <summary>
        /// Initializes a new instance of the Widget class.
        /// </summary>
        public Widget()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Widget class.
        /// </summary>
        public Widget(string title = default(string), string oid = default(string), string desc = default(string), WidgetDatasource datasource = default(WidgetDatasource), string type = default(string), string subtype = default(string), string dashboardid = default(string), string owner = default(string), string userId = default(string), string instanceType = default(string), System.DateTime? lastUpdated = default(System.DateTime?), WidgetMetadata metadata = default(WidgetMetadata), IList<WidgetSharesItem> shares = default(IList<WidgetSharesItem>))
        {
            Title = title;
            Oid = oid;
            Desc = desc;
            Datasource = datasource;
            Type = type;
            Subtype = subtype;
            Dashboardid = dashboardid;
            Owner = owner;
            UserId = userId;
            InstanceType = instanceType;
            LastUpdated = lastUpdated;
            Metadata = metadata;
            Shares = shares;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasource")]
        public WidgetDatasource Datasource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subtype")]
        public string Subtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dashboardid")]
        public string Dashboardid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instanceType")]
        public string InstanceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public WidgetMetadata Metadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares")]
        public IList<WidgetSharesItem> Shares { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Datasource != null)
            {
                Datasource.Validate();
            }
            if (Shares != null)
            {
                foreach (var element in Shares)
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