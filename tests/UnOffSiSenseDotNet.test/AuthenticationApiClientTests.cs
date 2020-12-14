using FakeItEasy;
using MarkZither.UnOffSiSenseDotNet;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UnOffSiSenseDotNet.V1.Models;
using Xunit;

namespace UnOffSiSenseDotNet.Tests
{
    public abstract class AuthenticationApiClientTestBase : SiSenseSDKTestBase
    {
        private AuthenticationApiClient CreateAuthenticationApiClient()
        {
            var httpClient = GetHttpClient();
            httpClient.BaseAddress = new Uri(configuration.BaseUrl);
            return new AuthenticationApiClient(httpClient, true);
        }

        [Fact]
        public async Task Login_Async()
        {
            // Arrange
            var authenticationApiClient = this.CreateAuthenticationApiClient();
            string username = userName;
            string password = configuration.Password;
            string xDeviceId = null;
            string localeId = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await authenticationApiClient.LoginAsync(
                username,
                password,
                xDeviceId,
                localeId,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(result.Body is LoginOKResponse);
        }
    }

    [Trait("Category", "Integration")]
    public class AuthenticationApiClientTests : AuthenticationApiClientTestBase
    {
        protected override HttpClient GetHttpClient() => HttpClientFactory.GetHttpClient();
    }

    [Trait("Category", "Unit")]
    public class AuthenticationApiClientWithMocksTests : AuthenticationApiClientTestBase
    {
        public AuthenticationApiClientWithMocksTests():base()
        {
            userName = "mark.burton@zither-it.co.uk";
        }
        protected override HttpClient GetHttpClient() => HttpClientFactory.GetMockHttpClient(configuration.BaseUrl);
    }
}
