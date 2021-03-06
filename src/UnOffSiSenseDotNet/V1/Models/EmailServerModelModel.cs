// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EmailServerModelModel
    {
        /// <summary>
        /// Initializes a new instance of the EmailServerModelModel class.
        /// </summary>
        public EmailServerModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmailServerModelModel class.
        /// </summary>
        /// <param name="_id">ID of config.</param>
        /// <param name="alias">Web server public address.</param>
        /// <param name="firstday">First day of the week for date related
        /// ElastiCube queries.</param>
        /// <param name="usage">Usage Analytics feature properties
        /// block.</param>
        /// <param name="fiscal">Fiscal Year.</param>
        /// <param name="dashboardAdministration">Allow admin access for all
        /// dashboards</param>
        /// <param name="dataExplore">Data Explore feature status</param>
        public EmailServerModelModel(string _id = default(string), string alias = default(string), string firstday = default(string), EmailServerUsage usage = default(EmailServerUsage), EmailServerFiscal fiscal = default(EmailServerFiscal), EmailServerDashboardAdministration dashboardAdministration = default(EmailServerDashboardAdministration), EmailServerDataExplore dataExplore = default(EmailServerDataExplore), EmailServerEmail email = default(EmailServerEmail), EmailServerWebServer webServer = default(EmailServerWebServer), EmailServerReporting reporting = default(EmailServerReporting), EmailServerAuthentication authentication = default(EmailServerAuthentication))
        {
            this._id = _id;
            Alias = alias;
            Firstday = firstday;
            Usage = usage;
            Fiscal = fiscal;
            DashboardAdministration = dashboardAdministration;
            DataExplore = dataExplore;
            Email = email;
            WebServer = webServer;
            Reporting = reporting;
            Authentication = authentication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of config.
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string _id { get; set; }

        /// <summary>
        /// Gets or sets web server public address.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or sets first day of the week for date related ElastiCube
        /// queries.
        /// </summary>
        [JsonProperty(PropertyName = "firstday")]
        public string Firstday { get; set; }

        /// <summary>
        /// Gets or sets usage Analytics feature properties block.
        /// </summary>
        [JsonProperty(PropertyName = "usage")]
        public EmailServerUsage Usage { get; set; }

        /// <summary>
        /// Gets or sets fiscal Year.
        /// </summary>
        [JsonProperty(PropertyName = "fiscal")]
        public EmailServerFiscal Fiscal { get; set; }

        /// <summary>
        /// Gets or sets allow admin access for all dashboards
        /// </summary>
        [JsonProperty(PropertyName = "dashboardAdministration")]
        public EmailServerDashboardAdministration DashboardAdministration { get; set; }

        /// <summary>
        /// Gets or sets data Explore feature status
        /// </summary>
        [JsonProperty(PropertyName = "dataExplore")]
        public EmailServerDataExplore DataExplore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public EmailServerEmail Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webServer")]
        public EmailServerWebServer WebServer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reporting")]
        public EmailServerReporting Reporting { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "authentication")]
        public EmailServerAuthentication Authentication { get; set; }

    }
}
