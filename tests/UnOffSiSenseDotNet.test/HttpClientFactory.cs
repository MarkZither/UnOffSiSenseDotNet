using MarkZither.UnOffSiSenseDotNet;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RichardSzalay.MockHttp;
using System.IO;
using System.Net;

namespace UnOffSiSenseDotNet.Tests
{
    public static class HttpClientFactory
    {
        public class ThrottlingHttpMessageHandler : HttpClientHandler
        {
            public int DelayInMilliSeconds { get; }

            public ThrottlingHttpMessageHandler(int delayInMilliSeconds)
            {
                DelayInMilliSeconds = delayInMilliSeconds;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                await Task.Delay(DelayInMilliSeconds);
                return await base.SendAsync(request, cancellationToken);
            }
        }

        public static HttpClient GetHttpClient(int delayInMillis = 1000)
        {
            return new HttpClient(new HttpRetryMessageHandler(new ThrottlingHttpMessageHandler(delayInMillis)));
        }

        public static HttpClient GetMockHttpClient(string serverEndpont)
        {
            var mockHttp = new MockHttpMessageHandler();

            #region Sign In

            mockHttp.When(HttpMethod.Post, $"{serverEndpont}v1/authentication/login")
                //.WithPartialContent("mark.burton@zither-it.co.uk")
                .Respond("application/json", File.ReadAllText(@"MockResponses\SignInAsync.json"));
            /*
            mockHttp.When(HttpMethod.Post, $"{serverEndpont}{version}/auth/signin_extended")
                .WithHeaders("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpYXQiOjE1NzM0ODM2MTMsIm5iZiI6MTU3MzQ4MzYxMywianRpIjoiZjQ0Mzk1NTYtOTg4NS00MjU4LThmMDktMjgzNThhMjI1YjM2IiwiZXhwIjoxNTczNTI2ODEzLCJpZGVudGl0eSI6MjUsImZyZXNoIjpmYWxzZSwidHlwZSI6ImFjY2VzcyIsInVzZXJfY2xhaW1zIjp7InNhdmVfaGlzdG9yeSI6dHJ1ZSwidXNlcl9pZCI6MjUsImNvbXBhbnlfaWQiOjEsInR5cGUiOiJhcHBfdXNlciIsImlzX2FkbWluIjpmYWxzZSwic3EiOjEwMDAwMCwicnNxIjowLCJhdCI6MTAsIm1yIjoxMDAwLCJzdCI6IlBST0ZFU1NJT05BTCJ9fQ.CMgXfxjjVRElqdL5AQ8pvEXzoPt5rBacvjKOQeImdeg")
                .Respond("application/json", File.ReadAllText(@"MockHttpResponse\SignInAsync.txt"));

            mockHttp.When(HttpMethod.Post, $"{serverEndpont}{version}/auth/signin_extended")
                .WithHeaders("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpYXQiOjE1NzM0ODM2MTMsIm5iZiI6MTU3MzQ4MzYxMywianRpIjoiZjQ0Mzk1NTYtOTg4NS00MjU4LThmMDktMjgzNThhMjI1YjM2IiwiZXhwIjoxNTczNTI2ODEzLCJpZGVudGl0eSI6MjUsImZyZXNoIjpmYWxzZSwidHlwZSI6ImFjY2VzcyIsInVzZXJfY2xhaW1zIjp7InNhdmVfaGlzdG9yeSI6dHJ1ZSwidXNlcl9pZCI6MjUsImNvbXBhbnlfaWQiOjEsInR5cGUiOiJhcHBfdXNlciIsImlzX2FkbWluIjpmYWxzZSwic3EiOjEwMDAwMCwicnNxIjowLCJhdCI6MTAsIm1yIjoxMDAwLCJzdCI6IlBST0ZFU1NJT05BTCJ9fQ.CMgXfxjjVRElqdL5AQ8pvEXzoPt5rBacvjKOQeImdeg")
                .WithPartialContent("unittest@fake.com")
                .WithPartialContent("fakepassword")
                .Respond(HttpStatusCode.Unauthorized, "application/json", new MemoryStream(Encoding.ASCII.GetBytes("{'messages':['These credentials do not match our records.']}")));
            */
            #endregion Sign In

            #region Sign Out
            /*
            mockHttp.When(HttpMethod.Post, $"{serverEndpont}{version}/auth/signout")
                .WithHeaders("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpYXQiOjE1NzM0ODM2MTMsIm5iZiI6MTU3MzQ4MzYxMywianRpIjoiZjQ0Mzk1NTYtOTg4NS00MjU4LThmMDktMjgzNThhMjI1YjM2IiwiZXhwIjoxNTczNTI2ODEzLCJpZGVudGl0eSI6MjUsImZyZXNoIjpmYWxzZSwidHlwZSI6ImFjY2VzcyIsInVzZXJfY2xhaW1zIjp7InNhdmVfaGlzdG9yeSI6dHJ1ZSwidXNlcl9pZCI6MjUsImNvbXBhbnlfaWQiOjEsInR5cGUiOiJhcHBfdXNlciIsImlzX2FkbWluIjpmYWxzZSwic3EiOjEwMDAwMCwicnNxIjowLCJhdCI6MTAsIm1yIjoxMDAwLCJzdCI6IlBST0ZFU1NJT05BTCJ9fQ.CMgXfxjjVRElqdL5AQ8pvEXzoPt5rBacvjKOQeImdeg")
                .Respond(System.Net.HttpStatusCode.NoContent, "application/json", new MemoryStream());
            */
            #endregion Sign Out

            return mockHttp.ToHttpClient();
        }
    }
}
