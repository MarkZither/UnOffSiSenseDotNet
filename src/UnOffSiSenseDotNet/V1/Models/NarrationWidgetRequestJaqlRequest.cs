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

    /// <summary>
    /// JAQL query object
    /// </summary>
    public partial class NarrationWidgetRequestJaqlRequest
    {
        /// <summary>
        /// Initializes a new instance of the NarrationWidgetRequestJaqlRequest
        /// class.
        /// </summary>
        public NarrationWidgetRequestJaqlRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NarrationWidgetRequestJaqlRequest
        /// class.
        /// </summary>
        /// <param name="format">data format</param>
        /// <param name="isMaskedResult">masked result check</param>
        /// <param name="count">narration text</param>
        /// <param name="offset">offset</param>
        public NarrationWidgetRequestJaqlRequest(string datasource, IList<NarrationWidgetRequestJaqlRequestMetadataItem> metadata, string format = default(string), bool? isMaskedResult = default(bool?), double? count = default(double?), double? offset = default(double?))
        {
            Datasource = datasource;
            Metadata = metadata;
            Format = format;
            IsMaskedResult = isMaskedResult;
            Count = count;
            Offset = offset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datasource")]
        public string Datasource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NarrationWidgetRequestJaqlRequestMetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets data format
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets masked result check
        /// </summary>
        [JsonProperty(PropertyName = "isMaskedResult")]
        public bool? IsMaskedResult { get; set; }

        /// <summary>
        /// Gets or sets narration text
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; set; }

        /// <summary>
        /// Gets or sets offset
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Datasource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Datasource");
            }
            if (Metadata == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Metadata");
            }
        }
    }
}
