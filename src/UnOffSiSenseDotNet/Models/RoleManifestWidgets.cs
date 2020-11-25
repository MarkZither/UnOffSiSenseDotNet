// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RoleManifestWidgets
    {
        /// <summary>
        /// Initializes a new instance of the RoleManifestWidgets class.
        /// </summary>
        public RoleManifestWidgets()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleManifestWidgets class.
        /// </summary>
        public RoleManifestWidgets(bool? changeType = default(bool?), bool? create = default(bool?), bool? delete = default(bool?), bool? drillToAnywhere = default(bool?), bool? duplicate = default(bool?), bool? editScript = default(bool?), bool? exportCsv = default(bool?), bool? exportPng = default(bool?), RoleManifestWidgetsFilters filters = default(RoleManifestWidgetsFilters), RoleManifestWidgetsItems items = default(RoleManifestWidgetsItems), bool? modifySelectionMode = default(bool?), bool? rename = default(bool?))
        {
            ChangeType = changeType;
            Create = create;
            Delete = delete;
            DrillToAnywhere = drillToAnywhere;
            Duplicate = duplicate;
            EditScript = editScript;
            ExportCsv = exportCsv;
            ExportPng = exportPng;
            Filters = filters;
            Items = items;
            ModifySelectionMode = modifySelectionMode;
            Rename = rename;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "change_type")]
        public bool? ChangeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "create")]
        public bool? Create { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delete")]
        public bool? Delete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "drill_to_anywhere")]
        public bool? DrillToAnywhere { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duplicate")]
        public bool? Duplicate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "edit_script")]
        public bool? EditScript { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_csv")]
        public bool? ExportCsv { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_png")]
        public bool? ExportPng { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public RoleManifestWidgetsFilters Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public RoleManifestWidgetsItems Items { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modify_selection_mode")]
        public bool? ModifySelectionMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rename")]
        public bool? Rename { get; set; }

    }
}
