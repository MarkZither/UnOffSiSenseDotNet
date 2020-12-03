// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GeoLocation
    {
        /// <summary>
        /// Initializes a new instance of the GeoLocation class.
        /// </summary>
        public GeoLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoLocation class.
        /// </summary>
        public GeoLocation(GeoCoordinates latLng, string name, string placetype, string asciiname = default(string), string country = default(string), string countryCode = default(string), string fqn = default(string), string lookupKey = default(string))
        {
            Asciiname = asciiname;
            Country = country;
            CountryCode = countryCode;
            Fqn = fqn;
            LatLng = latLng;
            LookupKey = lookupKey;
            Name = name;
            Placetype = placetype;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asciiname")]
        public string Asciiname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fqn")]
        public string Fqn { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latLng")]
        public GeoCoordinates LatLng { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lookupKey")]
        public string LookupKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "placetype")]
        public string Placetype { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LatLng == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LatLng");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Placetype == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Placetype");
            }
        }
    }
}