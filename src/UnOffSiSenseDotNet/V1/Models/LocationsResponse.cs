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

    public partial class LocationsResponse
    {
        /// <summary>
        /// Initializes a new instance of the LocationsResponse class.
        /// </summary>
        public LocationsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationsResponse class.
        /// </summary>
        public LocationsResponse(string name, LocationsResponseLatLng latLng, string placetype, string asciiname = default(string), string country = default(string), string countryCode = default(string), string fqn = default(string), string lookupKey = default(string), string text = default(string), string placeName = default(string), IList<LocationsResponseContextItem> context = default(IList<LocationsResponseContextItem>), string version = default(string), string _id = default(string))
        {
            Name = name;
            Asciiname = asciiname;
            LatLng = latLng;
            Placetype = placetype;
            Country = country;
            CountryCode = countryCode;
            Fqn = fqn;
            LookupKey = lookupKey;
            Text = text;
            PlaceName = placeName;
            Context = context;
            Version = version;
            this._id = _id;
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
        [JsonProperty(PropertyName = "asciiname")]
        public string Asciiname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latLng")]
        public LocationsResponseLatLng LatLng { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "placetype")]
        public string Placetype { get; set; }

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
        [JsonProperty(PropertyName = "lookupKey")]
        public string LookupKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public IList<LocationsResponseContextItem> Context { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (LatLng == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LatLng");
            }
            if (Placetype == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Placetype");
            }
        }
    }
}
