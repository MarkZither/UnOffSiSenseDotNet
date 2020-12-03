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

    public partial class AddDashboardCreatedResponse
    {
        /// <summary>
        /// Initializes a new instance of the AddDashboardCreatedResponse
        /// class.
        /// </summary>
        public AddDashboardCreatedResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddDashboardCreatedResponse
        /// class.
        /// </summary>
        public AddDashboardCreatedResponse(string title = default(string), string desc = default(string), string oid = default(string), string source = default(string), string parentFolder = default(string), string type = default(string), IList<AddDashboardCreatedResponseSharesItem> shares = default(IList<AddDashboardCreatedResponseSharesItem>), AddDashboardCreatedResponseStyle style = default(AddDashboardCreatedResponseStyle), string owner = default(string), string userId = default(string), System.DateTime? created = default(System.DateTime?), System.DateTime? lastUpdated = default(System.DateTime?), AddDashboardCreatedResponseDatasource datasource = default(AddDashboardCreatedResponseDatasource), IList<AddDashboardCreatedResponseFiltersItem> filters = default(IList<AddDashboardCreatedResponseFiltersItem>), string instanceType = default(string), bool? dataExploration = default(bool?), AddDashboardCreatedResponseLayout layout = default(AddDashboardCreatedResponseLayout), IList<AddDashboardCreatedResponsePreviewLayoutItem> previewLayout = default(IList<AddDashboardCreatedResponsePreviewLayoutItem>), IList<AddDashboardCreatedResponseDefaultFiltersItem> defaultFilters = default(IList<AddDashboardCreatedResponseDefaultFiltersItem>))
        {
            Title = title;
            Desc = desc;
            Oid = oid;
            Source = source;
            ParentFolder = parentFolder;
            Type = type;
            Shares = shares;
            Style = style;
            Owner = owner;
            UserId = userId;
            Created = created;
            LastUpdated = lastUpdated;
            Datasource = datasource;
            Filters = filters;
            InstanceType = instanceType;
            DataExploration = dataExploration;
            Layout = layout;
            PreviewLayout = previewLayout;
            DefaultFilters = defaultFilters;
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
        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string Oid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentFolder")]
        public string ParentFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares")]
        public IList<AddDashboardCreatedResponseSharesItem> Shares { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "style")]
        public AddDashboardCreatedResponseStyle Style { get; set; }

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
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdated")]
        public System.DateTime? LastUpdated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasource")]
        public AddDashboardCreatedResponseDatasource Datasource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<AddDashboardCreatedResponseFiltersItem> Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instanceType")]
        public string InstanceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataExploration")]
        public bool? DataExploration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "layout")]
        public AddDashboardCreatedResponseLayout Layout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previewLayout")]
        public IList<AddDashboardCreatedResponsePreviewLayoutItem> PreviewLayout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultFilters")]
        public IList<AddDashboardCreatedResponseDefaultFiltersItem> DefaultFilters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
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
            if (Datasource != null)
            {
                Datasource.Validate();
            }
        }
    }
}
