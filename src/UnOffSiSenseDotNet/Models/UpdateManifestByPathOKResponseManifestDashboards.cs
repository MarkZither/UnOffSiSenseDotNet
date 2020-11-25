// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateManifestByPathOKResponseManifestDashboards
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UpdateManifestByPathOKResponseManifestDashboards class.
        /// </summary>
        public UpdateManifestByPathOKResponseManifestDashboards()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UpdateManifestByPathOKResponseManifestDashboards class.
        /// </summary>
        public UpdateManifestByPathOKResponseManifestDashboards(bool? create = default(bool?), bool? duplicate = default(bool?), bool? editScript = default(bool?), bool? exportDash = default(bool?), bool? exportJpeg = default(bool?), bool? exportPdf = default(bool?), UpdateManifestByPathOKResponseManifestDashboardsFilters filters = default(UpdateManifestByPathOKResponseManifestDashboardsFilters), bool? import = default(bool?), bool? rename = default(bool?), bool? restore = default(bool?), bool? selectPalette = default(bool?), bool? toggleEditMode = default(bool?))
        {
            Create = create;
            Duplicate = duplicate;
            EditScript = editScript;
            ExportDash = exportDash;
            ExportJpeg = exportJpeg;
            ExportPdf = exportPdf;
            Filters = filters;
            Import = import;
            Rename = rename;
            Restore = restore;
            SelectPalette = selectPalette;
            ToggleEditMode = toggleEditMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "create")]
        public bool? Create { get; set; }

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
        [JsonProperty(PropertyName = "export_dash")]
        public bool? ExportDash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_jpeg")]
        public bool? ExportJpeg { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_pdf")]
        public bool? ExportPdf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public UpdateManifestByPathOKResponseManifestDashboardsFilters Filters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "import")]
        public bool? Import { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rename")]
        public bool? Rename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "restore")]
        public bool? Restore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "select_palette")]
        public bool? SelectPalette { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toggle_edit_mode")]
        public bool? ToggleEditMode { get; set; }

    }
}
