// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReportType
    {
        /// <summary>
        /// Initializes a new instance of the ReportType class.
        /// </summary>
        public ReportType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportType class.
        /// </summary>
        public ReportType(bool? inline = default(bool?), ReportTypePdf pdf = default(ReportTypePdf))
        {
            Inline = inline;
            Pdf = pdf;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inline")]
        public bool? Inline { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pdf")]
        public ReportTypePdf Pdf { get; set; }

    }
}
