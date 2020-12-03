using FakeItEasy;
using System;
using System.Threading.Tasks;
using UnOffSiSenseDotNet.V1;
using Xunit;

namespace UnOffSiSenseDotNet.test.V1
{
    public class SiSenseSDKExtensionsTests
    {


        public SiSenseSDKExtensionsTests()
        {

        }

        private SiSenseSDKExtensions CreateSiSenseSDKExtensions()
        {
            return new SiSenseSDKExtensions();
        }

        [Fact]
        public void SendReports_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            ReportObjectModel reportObject = null;

            // Act
            var result = siSenseSDKExtensions.SendReports(
                operations,
                reportObject);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task SendReportsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            ReportObjectModel reportObject = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.SendReportsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetCardsNames(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetCardsNamesAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetCardByName(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetCardByNameAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            string snippetType = null;

            // Act
            var result = siSenseSDKExtensions.GetSnippets(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            string snippetType = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetSnippetsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetCustomActions(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetCustomActionsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetActionByType(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetActionByTypeAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.SaveNewTamplate(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.SaveNewTamplateAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.SaveCustomAction(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.SaveCustomActionAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.DeleteCard(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.DeleteCardAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.DeleteCustomAction(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.DeleteCustomActionAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.Logger(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.LoggerAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.CardAnalysis(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string path = null;
            object body = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.CardAnalysisAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.GetEmailServer(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetEmailServerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetEmailServerAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void AddEmailServer_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            EmailServer emailServer = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.AddEmailServer(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            EmailServer emailServer = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.AddEmailServerAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            EmailServerModel emailServer = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.UpdateEmailServer(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            EmailServerModel emailServer = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.UpdateEmailServerAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            siSenseSDKExtensions.DeleteEmailServer(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteEmailServerAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            await siSenseSDKExtensions.DeleteEmailServerAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetPublicSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.GetPublicSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPublicSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetPublicSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void GetSsoSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.GetSsoSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSsoSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetSsoSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SetSsoSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Sso sso = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.SetSsoSettings(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Sso sso = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.SetSsoSettingsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.GetSystemSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetSystemSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetSystemSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SetSystemSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            EmailServerModelModel emailServer = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.SetSystemSettings(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            EmailServerModelModel emailServer = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.SetSystemSettingsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetGlobalization(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetGlobalizationAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetGlobalizationAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.Add(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.AddAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.Update(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Globalization globalization = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.UpdateAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.RemoveGlobalization(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemoveGlobalizationAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.RemoveGlobalizationAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetTranslation(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetTranslationAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetTranslationAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.GetPulseSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPulseSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetPulseSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void SetPulseSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.SetPulseSettings(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.SetPulseSettingsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.Patch(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Pulse pulse = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.PatchAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.RemovePulseSettings(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task RemovePulseSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.RemovePulseSettingsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.GetPivotSettings(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetPivotSettingsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetPivotSettingsAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void PatchPivotSettings_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Pivot pivot = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.PatchPivotSettings(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            Pivot pivot = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.PatchPivotSettingsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetLang(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetLangAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetIntlLang(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string lang = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetIntlLangAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.GetAllLangs(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllLangsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetAllLangsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;

            // Act
            var result = siSenseSDKExtensions.Get(
                operations);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetAsync(
                operations,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void UpdateLockoutUsingPatch_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            LoginLockoutSettings loginLockoutSettings = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.UpdateLockoutUsingPatch(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            LoginLockoutSettings loginLockoutSettings = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.UpdateLockoutUsingPatchAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string cubeTitle = null;
            string server = null;

            // Act
            var result = siSenseSDKExtensions.GetEcmModelUsingGET(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string cubeTitle = null;
            string server = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.GetEcmModelUsingGETAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string username = null;
            string password = null;
            string xDeviceId = null;
            string localeId = null;

            // Act
            var result = siSenseSDKExtensions.Login(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string username = null;
            string password = null;
            string xDeviceId = null;
            string localeId = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.LoginAsync(
                operations,
                username,
                password,
                xDeviceId,
                localeId,
                cancellationToken);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public void Logout_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            string targetDevice = null;

            // Act
            var result = siSenseSDKExtensions.Logout(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            string targetDevice = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.LogoutAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.LogoutAll(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.LogoutAllAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            object empty = null;

            // Act
            var result = siSenseSDKExtensions.LogoutAllUsers(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string xDeviceId = null;
            string authorization = null;
            object empty = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.LogoutAllUsersAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            IList users = null;
            string xDeviceId = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.LogoutUsers(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            IList users = null;
            string xDeviceId = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.LogoutUsersAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string tokenType = null;
            IList users = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.RevokeTokens(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string tokenType = null;
            IList users = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.RevokeTokensAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string relayState = null;
            string sAMLResponse = null;

            // Act
            siSenseSDKExtensions.SamlLoginCallback(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string relayState = null;
            string sAMLResponse = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            await siSenseSDKExtensions.SamlLoginCallbackAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;

            // Act
            siSenseSDKExtensions.GetAllServersAccess(
                operations,
                authorization);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllServersAccessAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            await siSenseSDKExtensions.GetAllServersAccessAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            ServerAccess serverAccess = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.AddServerAccess(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            ServerAccess serverAccess = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.AddServerAccessAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            string authorization = null;
            string parentFolder = null;
            string name = null;
            string datasourceTitle = null;
            string datasourceAddress = null;
            string fields = null;
            string expand = null;

            // Act
            var result = siSenseSDKExtensions.GetOwnedDashboards(
                operations,
                authorization,
                parentFolder,
                name,
                datasourceTitle,
                datasourceAddress,
                fields,
                expand);

            // Assert
            Assert.True(false);
        }

        [Fact]
        public async Task GetOwnedDashboardsAsync_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
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
            var result = await siSenseSDKExtensions.GetOwnedDashboardsAsync(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            DashboardModel dashboard = null;
            string authorization = null;

            // Act
            var result = siSenseSDKExtensions.AddDashboard(
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
            var siSenseSDKExtensions = this.CreateSiSenseSDKExtensions();
            ISiSenseSDK operations = null;
            DashboardModel dashboard = null;
            string authorization = null;
            CancellationToken cancellationToken = default(global::System.Threading.CancellationToken);

            // Act
            var result = await siSenseSDKExtensions.AddDashboardAsync(
                operations,
                dashboard,
                authorization,
                cancellationToken);

            // Assert
            Assert.True(false);
        }
    }
}
