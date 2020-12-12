using Microsoft.Extensions.Configuration;
using UnOffSiSenseDotNet.test.V1;

namespace UnOffSiSenseDotNet.test
{
    public static class TestHelper
    {
        public static IConfiguration GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets<SiSenseSDKExtensionsTests>()
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
}