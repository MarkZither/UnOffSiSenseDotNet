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

    /// <summary>
    /// BaseConnectionParameter
    /// </summary>
    public partial class BaseConnectionParameter
    {
        /// <summary>
        /// Initializes a new instance of the BaseConnectionParameter class.
        /// </summary>
        public BaseConnectionParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseConnectionParameter class.
        /// </summary>
        public BaseConnectionParameter(string name = default(string), string title = default(string), string titleTranslationKey = default(string), string type = default(string), string icon = default(string), bool? required = default(bool?), bool? send = default(bool?), string defaultProperty = default(string), string description = default(string), string descriptionTranslationKey = default(string), string pattern = default(string), bool? trim = default(bool?), int? min = default(int?), int? max = default(int?), bool? multivalue = default(bool?), IList<Option> options = default(IList<Option>), Condition availableIf = default(Condition))
        {
            Name = name;
            Title = title;
            TitleTranslationKey = titleTranslationKey;
            Type = type;
            Icon = icon;
            Required = required;
            Send = send;
            DefaultProperty = defaultProperty;
            Description = description;
            DescriptionTranslationKey = descriptionTranslationKey;
            Pattern = pattern;
            Trim = trim;
            Min = min;
            Max = max;
            Multivalue = multivalue;
            Options = options;
            AvailableIf = availableIf;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "titleTranslationKey")]
        public string TitleTranslationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "send")]
        public bool? Send { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public string DefaultProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "descriptionTranslationKey")]
        public string DescriptionTranslationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "trim")]
        public bool? Trim { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "min")]
        public int? Min { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "max")]
        public int? Max { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multivalue")]
        public bool? Multivalue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public IList<Option> Options { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "availableIf")]
        public Condition AvailableIf { get; set; }

    }
}
