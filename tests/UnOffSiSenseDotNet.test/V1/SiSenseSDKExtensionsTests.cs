using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using UnOffSiSenseDotNet.V1;
using UnOffSiSenseDotNet.V1.Models;
using Xunit;

namespace UnOffSiSenseDotNet.test.V1
{
    public class SiSenseSDKExtensionsTests
    {
        private string authorization;

        public string Authorization
        {
            get
            {
                if (!string.IsNullOrEmpty(authorization))
                {
                    return authorization;
                }
                System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
                httpClient.BaseAddress = new Uri(configuration.BaseUrl);
                //ISiSenseSDK operations = new SiSenseSDK(httpClient, true);
                ISiSenseSDK operations = new SiSenseSDK(new Uri(configuration.BaseUrl));
                string username = configuration.Username;
                string password = configuration.Password;
                string xDeviceId = null;
                string localeId = null;

                var result = (LoginOKResponse)SiSenseSDKExtensions.Login(
                    operations,
                    username,
                    password,
                    xDeviceId,
                    localeId);

                authorization = "Bearer " + result.AccessToken;

                return authorization;
            }
            set { authorization = value; }
        }

        private SiSenseConfiguration configuration;

        public SiSenseSDKExtensionsTests()
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
        }

        [Fact]
        public void SendReports_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = null;
            ReportObjectModel reportObject = null;

            // Act
            var result = SiSenseSDKExtensions.SendReports(
                operations,
                reportObject);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SendReportsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = null;
            ReportObjectModel reportObject = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.SendReportsAsync(
                operations,
                reportObject,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetCardsNames_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetCardsNames(
                operations,
                path,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCardsNamesAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetCardsNamesAsync(
                operations,
                path,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetCardByName_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetCardByName(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCardByNameAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetCardByNameAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSnippets_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            string snippetType = null;

            // Act
            var result = SiSenseSDKExtensions.GetSnippets(
                operations,
                path,
                authorization,
                snippetType);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSnippetsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            string snippetType = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetSnippetsAsync(
                operations,
                path,
                authorization,
                snippetType,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetCustomActions_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetCustomActions(
                operations,
                path,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetCustomActionsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetCustomActionsAsync(
                operations,
                path,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetActionByType_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetActionByType(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetActionByTypeAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetActionByTypeAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SaveNewTamplate_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.SaveNewTamplate(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SaveNewTamplateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.SaveNewTamplateAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SaveCustomAction_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.SaveCustomAction(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SaveCustomActionAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.SaveCustomActionAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void DeleteCard_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.DeleteCard(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteCardAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.DeleteCardAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void DeleteCustomAction_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.DeleteCustomAction(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteCustomActionAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.DeleteCustomActionAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Logger_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.Logger(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LoggerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.LoggerAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void CardAnalysis_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.CardAnalysis(
                operations,
                path,
                body,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task CardAnalysisAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.CardAnalysisAsync(
                operations,
                path,
                body,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetEmailServer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.GetEmailServer(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetEmailServerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetEmailServerAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void AddEmailServer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            EmailServer emailServer = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.AddEmailServer(
                operations,
                emailServer,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddEmailServerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            EmailServer emailServer = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.AddEmailServerAsync(
                operations,
                emailServer,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void UpdateEmailServer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            EmailServerModel emailServer = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.UpdateEmailServer(
                operations,
                emailServer,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateEmailServerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            EmailServerModel emailServer = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.UpdateEmailServerAsync(
                operations,
                emailServer,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void DeleteEmailServer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            SiSenseSDKExtensions.DeleteEmailServer(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteEmailServerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            await SiSenseSDKExtensions.DeleteEmailServerAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetPublicSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.GetPublicSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPublicSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetPublicSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSsoSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.GetSsoSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSsoSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetSsoSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SetSsoSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Sso sso = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.SetSsoSettings(
                operations,
                sso,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SetSsoSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Sso sso = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.SetSsoSettingsAsync(
                operations,
                sso,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSystemSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.GetSystemSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSystemSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetSystemSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SetSystemSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            EmailServerModelModel emailServer = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.SetSystemSettings(
                operations,
                emailServer,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SetSystemSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            EmailServerModelModel emailServer = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.SetSystemSettingsAsync(
                operations,
                emailServer,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetGlobalization_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetGlobalization(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetGlobalizationAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetGlobalizationAsync(
                operations,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.Add(
                operations,
                globalization,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.AddAsync(
                operations,
                globalization,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Update_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.Update(
                operations,
                globalization,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.UpdateAsync(
                operations,
                globalization,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void RemoveGlobalization_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.RemoveGlobalization(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemoveGlobalizationAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.RemoveGlobalizationAsync(
                operations,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetTranslation_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetTranslation(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetTranslationAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetTranslationAsync(
                operations,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetPulseSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.GetPulseSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPulseSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetPulseSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SetPulseSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.SetPulseSettings(
                operations,
                pulse,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SetPulseSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.SetPulseSettingsAsync(
                operations,
                pulse,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Patch_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.Patch(
                operations,
                pulse,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task PatchAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.PatchAsync(
                operations,
                pulse,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void RemovePulseSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.RemovePulseSettings(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemovePulseSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.RemovePulseSettingsAsync(
                operations,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetPivotSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.GetPivotSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPivotSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetPivotSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void PatchPivotSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Pivot pivot = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.PatchPivotSettings(
                operations,
                pivot,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task PatchPivotSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            Pivot pivot = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.PatchPivotSettingsAsync(
                operations,
                pivot,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetLang_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetLang(
                operations,
                lang,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetLangAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetLangAsync(
                operations,
                lang,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetIntlLang_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetIntlLang(
                operations,
                lang,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetIntlLangAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetIntlLangAsync(
                operations,
                lang,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetAllLangs_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.GetAllLangs(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllLangsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetAllLangsAsync(
                operations,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Get_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;

            // Act
            var result = SiSenseSDKExtensions.Get(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void UpdateLockoutUsingPatch_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            LoginLockoutSettings loginLockoutSettings = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.UpdateLockoutUsingPatch(
                operations,
                loginLockoutSettings,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateLockoutUsingPatchAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            LoginLockoutSettings loginLockoutSettings = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.UpdateLockoutUsingPatchAsync(
                operations,
                loginLockoutSettings,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetEcmModelUsingGET_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string cubeTitle = null;
            string server = null;

            // Act
            var result = SiSenseSDKExtensions.GetEcmModelUsingGET(
                operations,
                cubeTitle,
                server);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetEcmModelUsingGETAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string cubeTitle = null;
            string server = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetEcmModelUsingGETAsync(
                operations,
                cubeTitle,
                server,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Login_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string username = null;
            string password = null;
            string xDeviceId = null;
            string localeId = null;

            // Act
            var result = SiSenseSDKExtensions.Login(
                operations,
                username,
                password,
                xDeviceId,
                localeId);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LoginAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            httpClient.BaseAddress = new Uri(configuration.BaseUrl);
            //ISiSenseSDK operations = new SiSenseSDK(httpClient, true);
            ISiSenseSDK operations = new SiSenseSDK(new Uri(configuration.BaseUrl));
            string username = configuration.Username;
            string password = configuration.Password;
            string xDeviceId = null;
            string localeId = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.LoginAsync(
                operations,
                username,
                password,
                xDeviceId,
                localeId,
                cancellationToken);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Logout_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            string targetDevice = null;

            // Act
            var result = SiSenseSDKExtensions.Logout(
                operations,
                xDeviceId,
                authorization,
                targetDevice);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            string targetDevice = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.LogoutAsync(
                operations,
                xDeviceId,
                authorization,
                targetDevice,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void LogoutAll_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.LogoutAll(
                operations,
                xDeviceId,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutAllAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.LogoutAllAsync(
                operations,
                xDeviceId,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void LogoutAllUsers_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            object empty = null;

            // Act
            var result = SiSenseSDKExtensions.LogoutAllUsers(
                operations,
                xDeviceId,
                authorization,
                empty);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutAllUsersAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            object empty = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.LogoutAllUsersAsync(
                operations,
                xDeviceId,
                authorization,
                empty,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void LogoutUsers_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            IList<string> users = null;
            string xDeviceId = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.LogoutUsers(
                operations,
                users,
                xDeviceId,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task LogoutUsersAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            IList<string> users = null;
            string xDeviceId = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.LogoutUsersAsync(
                operations,
                users,
                xDeviceId,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void RevokeTokens_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string tokenType = null;
            IList<string> users = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.RevokeTokens(
                operations,
                tokenType,
                users,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RevokeTokensAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string tokenType = null;
            IList<string> users = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.RevokeTokensAsync(
                operations,
                tokenType,
                users,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SamlLoginCallback_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string relayState = null;
            string sAMLResponse = null;

            // Act
            SiSenseSDKExtensions.SamlLoginCallback(
                operations,
                relayState,
                sAMLResponse);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SamlLoginCallbackAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string relayState = null;
            string sAMLResponse = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            await SiSenseSDKExtensions.SamlLoginCallbackAsync(
                operations,
                relayState,
                sAMLResponse,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetAllServersAccess_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            SiSenseSDKExtensions.GetAllServersAccess(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllServersAccessAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            await SiSenseSDKExtensions.GetAllServersAccessAsync(
                operations,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void AddServerAccess_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            ServerAccess serverAccess = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.AddServerAccess(
                operations,
                serverAccess,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddServerAccessAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            ISiSenseSDK operations = null;
            ServerAccess serverAccess = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.AddServerAccessAsync(
                operations,
                serverAccess,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetOwnedDashboards_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = new SiSenseSDK(new Uri(configuration.BaseUrl));
            string parentFolder = null;
            string name = null;
            string datasourceTitle = null;
            string datasourceAddress = null;
            string fields = null;
            string expand = null;

            // Act
            var result = SiSenseSDKExtensions.GetOwnedDashboards(
                operations,
                Authorization,
                parentFolder,
                name,
                datasourceTitle,
                datasourceAddress,
                fields,
                expand);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetOwnedDashboardsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = null;
            string authorization = null;
            string parentFolder = null;
            string name = null;
            string datasourceTitle = null;
            string datasourceAddress = null;
            string fields = null;
            string expand = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.GetOwnedDashboardsAsync(
                operations,
                authorization,
                parentFolder,
                name,
                datasourceTitle,
                datasourceAddress,
                fields,
                expand,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void AddDashboard_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = null;
            DashboardModel dashboard = null;
            string authorization = null;

            // Act
            var result = SiSenseSDKExtensions.AddDashboard(
                operations,
                dashboard,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task AddDashboardAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            ISiSenseSDK operations = null;
            DashboardModel dashboard = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await SiSenseSDKExtensions.AddDashboardAsync(
                operations,
                dashboard,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }
    }
}