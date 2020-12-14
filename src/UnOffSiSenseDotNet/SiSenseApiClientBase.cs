using Microsoft.Rest;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace MarkZither.UnOffSiSenseDotNet
{
    public class SiSenseApiClientBase : ServiceClient<SiSenseApiClientBase>
    {
        public SiSenseApiClientBase()
        {

        }

        public SiSenseApiClientBase(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            BaseUri = httpClient.BaseAddress;
        }
        public SiSenseApiClientBase(Uri baseUri, DelegatingHandler[] handlers):base (handlers)
        {
            BaseUri = baseUri;
        }

        public SiSenseApiClientBase(Uri baseUri, HttpClientHandler rootHandler, DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            BaseUri = baseUri;
        }

        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }
    }
}