using FakeItEasy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using UnOffSiSenseDotNet.V1;
using UnOffSiSenseDotNet.V1.Models;
using Xunit;

namespace UnOffSiSenseDotNet.test.V1
{
    public class SiSenseSDKTests
    {
        private SiSenseConfiguration configuration;
        private HttpClient fakeHttpClient;

        public SiSenseSDKTests()
        {
            Assembly TestAssembly;
            // Instantiate a target object.
            SiSenseConfiguration Config1 = new SiSenseConfiguration();
            Type Type1;
            // Set the Type instance to the target class type.
            Type1 = Config1.GetType();
            // Instantiate an Assembly class to the assembly housing the Integer type.
            TestAssembly = Assembly.GetAssembly(Config1.GetType());
            // Display the physical location of the assembly containing the manifest.
            Console.WriteLine("Location=" + TestAssembly.Location);
            var dirPath = Path.GetDirectoryName(TestAssembly.Location);
            configuration = TestHelper.GetApplicationConfiguration(dirPath);

            this.fakeHttpClient = A.Fake<HttpClient>();

        }

        private SiSenseSDK CreateSiSenseSDK()
        {
            return new SiSenseSDK(
                this.fakeHttpClient, true);
        }

        [Fact]
        public async Task SendReportsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            ReportObjectModel reportObject = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SendReportsWithHttpMessagesAsync(
                reportObject,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCardsNamesWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetCardsNamesWithHttpMessagesAsync(
                path,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCardByNameWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetCardByNameWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSnippetsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            string authorization = null;
            string snippetType = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetSnippetsWithHttpMessagesAsync(
                path,
                authorization,
                snippetType,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCustomActionsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetCustomActionsWithHttpMessagesAsync(
                path,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetActionByTypeWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetActionByTypeWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SaveNewTamplateWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SaveNewTamplateWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SaveCustomActionWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SaveCustomActionWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteCardWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.DeleteCardWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteCustomActionWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.DeleteCustomActionWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LoggerWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.LoggerWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CardAnalysisWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string path = null;
            object body = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.CardAnalysisWithHttpMessagesAsync(
                path,
                body,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetEmailServerWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetEmailServerWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddEmailServerWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            EmailServer emailServer = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.AddEmailServerWithHttpMessagesAsync(
                emailServer,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateEmailServerWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            EmailServerModel emailServer = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.UpdateEmailServerWithHttpMessagesAsync(
                emailServer,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteEmailServerWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.DeleteEmailServerWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPublicSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetPublicSettingsWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSsoSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetSsoSettingsWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SetSsoSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Sso sso = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SetSsoSettingsWithHttpMessagesAsync(
                sso,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSystemSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetSystemSettingsWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SetSystemSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            EmailServerModelModel emailServer = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SetSystemSettingsWithHttpMessagesAsync(
                emailServer,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetGlobalizationWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetGlobalizationWithHttpMessagesAsync(
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Globalization globalization = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.AddWithHttpMessagesAsync(
                globalization,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Globalization globalization = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.UpdateWithHttpMessagesAsync(
                globalization,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemoveGlobalizationWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.RemoveGlobalizationWithHttpMessagesAsync(
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetTranslationWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetTranslationWithHttpMessagesAsync(
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPulseSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetPulseSettingsWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SetPulseSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Pulse pulse = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SetPulseSettingsWithHttpMessagesAsync(
                pulse,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task PatchWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Pulse pulse = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.PatchWithHttpMessagesAsync(
                pulse,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemovePulseSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.RemovePulseSettingsWithHttpMessagesAsync(
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPivotSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetPivotSettingsWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task PatchPivotSettingsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Pivot pivot = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.PatchPivotSettingsWithHttpMessagesAsync(
                pivot,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetLangWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string lang = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetLangWithHttpMessagesAsync(
                lang,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetIntlLangWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string lang = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetIntlLangWithHttpMessagesAsync(
                lang,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllLangsWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetAllLangsWithHttpMessagesAsync(
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetWithHttpMessagesAsync(
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateLockoutUsingPatchWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            LoginLockoutSettings loginLockoutSettings = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.UpdateLockoutUsingPatchWithHttpMessagesAsync(
                loginLockoutSettings,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetEcmModelUsingGETWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string cubeTitle = null;
            string server = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetEcmModelUsingGETWithHttpMessagesAsync(
                cubeTitle,
                server,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LoginWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string username = null;
            string password = null;
            string xDeviceId = null;
            string localeId = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.LoginWithHttpMessagesAsync(
                username,
                password,
                xDeviceId,
                localeId,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string xDeviceId = null;
            string authorization = null;
            string targetDevice = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.LogoutWithHttpMessagesAsync(
                xDeviceId,
                authorization,
                targetDevice,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutAllWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string xDeviceId = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.LogoutAllWithHttpMessagesAsync(
                xDeviceId,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutAllUsersWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string xDeviceId = null;
            string authorization = null;
            object empty = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.LogoutAllUsersWithHttpMessagesAsync(
                xDeviceId,
                authorization,
                empty,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutUsersWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            IList<string> users = null;
            string xDeviceId = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.LogoutUsersWithHttpMessagesAsync(
                users,
                xDeviceId,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RevokeTokensWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string tokenType = null;
            IList<string> users = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.RevokeTokensWithHttpMessagesAsync(
                tokenType,
                users,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SamlLoginCallbackWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string relayState = null;
            string sAMLResponse = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.SamlLoginCallbackWithHttpMessagesAsync(
                relayState,
                sAMLResponse,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllServersAccessWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.GetAllServersAccessWithHttpMessagesAsync(
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddServerAccessWithHttpMessagesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDK = this.CreateSiSenseSDK();
            ServerAccess serverAccess = null;
            string authorization = null;
            Dictionary<string, List<string>> customHeaders = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDK.AddServerAccessWithHttpMessagesAsync(
                serverAccess,
                authorization,
                customHeaders,
                cancellationToken);

            // Assert
            Assert.True(false);
        }
    }
}
