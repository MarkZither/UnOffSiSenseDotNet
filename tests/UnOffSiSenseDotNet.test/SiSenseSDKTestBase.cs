using System;
using System.IO;
using System.Net.Http;
using System.Reflection;

namespace UnOffSiSenseDotNet.Tests
{
    public abstract class SiSenseSDKTestBase
    {
        protected abstract HttpClient GetHttpClient();
        public string userName { get; set; }

        public SiSenseConfiguration configuration;

        public SiSenseSDKTestBase()
        {
            Assembly TestAssembly;
            // Instantiate a target object.
            SiSenseConfiguration Config1 = new SiSenseConfiguration();
            Type Type1;
            // Set the Type instance to the target class type.
            Type1 = Config1.GetType();
            // Instantiate an Assembly class to the assembly housing the Integer type.
            TestAssembly = Assembly.GetAssembly(Config1.GetType());
            var dirPath = Path.GetDirectoryName(TestAssembly.Location);
            configuration = TestHelper.GetApplicationConfiguration(dirPath);
            userName = configuration.Username;
        }
    }
}