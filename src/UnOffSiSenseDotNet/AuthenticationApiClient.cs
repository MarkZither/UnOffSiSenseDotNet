using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnOffSiSenseDotNet.V1.Models;

namespace MarkZither.UnOffSiSenseDotNet
{
    public class AuthenticationApiClient : SiSenseApiClientBase, IAuthenticationApiClient
    {
        /// <summary>
        /// Initializes a new instance of the SiSenseSDK class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        public AuthenticationApiClient(Uri baseUri)
        {
            BaseUri = baseUri;
        }


        /// <summary>
        /// Initializes a new instance of the SiSenseSDK class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling SiSenseSDK.Dispose(). False: will not dispose provided httpClient</param>
        public AuthenticationApiClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            //Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the SiSenseSDK class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AuthenticationApiClient(System.Uri baseUri, params DelegatingHandler[] handlers) : base(baseUri, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the SiSenseSDK class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AuthenticationApiClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(baseUri, rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Authenticate and receive token
        /// </summary>
        /// <remarks>
        /// The **login** endpoint validates passed credentials and returns an API
        /// token for subsequent requests to the API.
        ///
        /// </remarks>
        /// <param name='username'>
        /// User's username or email
        /// </param>
        /// <param name='password'>
        /// User's password in plain text
        /// </param>
        /// <param name='xDeviceId'>
        /// The device id.
        /// </param>
        /// <param name='localeId'>
        /// User's locale, as ISO language code (See
        /// [table](http://www.lingoes.net/en/translator/langcode.htm))
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<object>> LoginAsync(string username, string password, string xDeviceId = default(string), string localeId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "username");
            }
            if (password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "password");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("xDeviceId", xDeviceId);
                tracingParameters.Add("username", username);
                tracingParameters.Add("password", password);
                tracingParameters.Add("localeId", localeId);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Login", tracingParameters);
            }
            // Construct URL
            var _baseUrl = BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v1/authentication/login").ToString();
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (xDeviceId != null)
            {
                if (_httpRequest.Headers.Contains("x-device-id"))
                {
                    _httpRequest.Headers.Remove("x-device-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-device-id", xDeviceId);
            }


            if (customHeaders != null)
            {
                foreach (var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            var values = new List<KeyValuePair<string, string>>();
            if (username != null)
            {
                values.Add(new KeyValuePair<string, string>("username", username));
            }
            if (password != null)
            {
                values.Add(new KeyValuePair<string, string>("password", password));
            }
            if (localeId != null)
            {
                values.Add(new KeyValuePair<string, string>("localeId", localeId));
            }
            var _formContent = new FormUrlEncodedContent(values);
            _httpRequest.Content = _formContent;
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200 && (int)_statusCode != 401)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null)
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else
                {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<LoginOKResponse>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            // Deserialize Response
            if ((int)_statusCode == 401)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<LoginUnauthorizedResponse>(_responseContent, DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }
    }

    public interface IAuthenticationApiClient
    {
        /// <summary>
        /// Authenticate and receive token
        /// </summary>
        /// <remarks>
        /// The **login** endpoint validates passed credentials and returns an
        /// API token for subsequent requests to the API.
        ///
        /// </remarks>
        /// <param name='username'>
        /// User's username or email
        /// </param>
        /// <param name='password'>
        /// User's password in plain text
        /// </param>
        /// <param name='xDeviceId'>
        /// The device id.
        /// </param>
        /// <param name='localeId'>
        /// User's locale, as ISO language code (See
        /// [table](http://www.lingoes.net/en/translator/langcode.htm))
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> LoginAsync(string username, string password, string xDeviceId = default(string), string localeId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
