// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class BaseDashboard
    {
        /// <summary>
        /// Initializes a new instance of the BaseDashboard class.
        /// </summary>
        public BaseDashboard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseDashboard class.
        /// </summary>
        public BaseDashboard(string title, BaseDashboardDatasource datasource, bool? showInMobileFeaturedList = default(bool?), string desc = default(string), string parentFolder = default(string), IList<BaseDashboardFiltersItem> filters = default(IList<BaseDashboardFiltersItem>), BaseDashboardLayout layout = default(BaseDashboardLayout), IList<BaseDashboardPreviewLayoutItem> previewLayout = default(IList<BaseDashboardPreviewLayoutItem>), IList<BaseDashboardDefaultFiltersItem> defaultFilters = default(IList<BaseDashboardDefaultFiltersItem>))
        {
            Title = title;
            ShowInMobileFeaturedList = showInMobileFeaturedList;
            Desc = desc;
            ParentFolder = parentFolder;
            Datasource = datasource;
            Filters = filters;
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
        [JsonProperty(PropertyName = "showInMobileFeaturedList")]
        public bool? ShowInMobileFeaturedList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentFolder")]
        public string ParentFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasource")]
        public BaseDashboardDatasource Datasource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<BaseDashboardFiltersItem> Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "layout")]
        public BaseDashboardLayout Layout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "previewLayout")]
        public IList<BaseDashboardPreviewLayoutItem> PreviewLayout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "defaultFilters")]
        public IList<BaseDashboardDefaultFiltersItem> DefaultFilters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Datasource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Datasource");
            }
            if (Datasource != null)
            {
                Datasource.Validate();
            }
        }
    }
}