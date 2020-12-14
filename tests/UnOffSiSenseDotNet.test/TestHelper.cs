using Microsoft.Extensions.Configuration;
using System;

namespace UnOffSiSenseDotNet.Tests
{
    public static class TestHelper
    {
        public static IConfiguration GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets<AuthenticationApiClientTests>()
                .AddEnvironmentVariables()
                .Build();
        }

        public static SiSenseConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new SiSenseConfiguration();

            var iConfig = GetIConfigurationRoot(outputPath);

            iConfig
                .GetSection("SiSense")
                .Bind(configuration);

            return configuration;
        }
    }
    public sealed class Authorization
    {
        private static readonly Lazy<Authorization>
            lazy =
            new Lazy<Authorization>
                (() => new Authorization());

        public static Authorization Instance { get { return lazy.Value; } }

        private Authorization()
        {
        }

        public string token;
    }
}