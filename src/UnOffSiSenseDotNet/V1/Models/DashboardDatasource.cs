// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DashboardDatasource
    {
        /// <summary>
        /// Initializes a new instance of the DashboardDatasource class.
        /// </summary>
        public DashboardDatasource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DashboardDatasource class.
        /// </summary>
        public DashboardDatasource(string title, string id = default(string), string address = default(string), string database = default(string), string fullname = default(string))
        {
            Title = title;
            Id = id;
            Address = address;
            Database = database;
            Fullname = fullname;
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
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "database")]
        public string Database { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullname")]
        public string Fullname { get; set; }

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
        }
    }
}
