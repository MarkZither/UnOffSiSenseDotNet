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
    /// auditFile
    /// </summary>
    public partial class ListAuditLogFilesOKResponseItem
    {
        /// <summary>
        /// Initializes a new instance of the ListAuditLogFilesOKResponseItem
        /// class.
        /// </summary>
        public ListAuditLogFilesOKResponseItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListAuditLogFilesOKResponseItem
        /// class.
        /// </summary>
        /// <param name="file">audit log filename</param>
        /// <param name="valid">indicates whether the audit log file is
        /// valid</param>
        /// <param name="filePath">audit log file path</param>
        public ListAuditLogFilesOKResponseItem(string file = default(string), bool? valid = default(bool?), string filePath = default(string))
        {
            File = file;
            Valid = valid;
            FilePath = filePath;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets audit log filename
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the audit log file is valid
        /// </summary>
        [JsonProperty(PropertyName = "valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// Gets or sets audit log file path
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

    }
}
