// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GetBrandingOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetBrandingOKResponse class.
        /// </summary>
        public GetBrandingOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetBrandingOKResponse class.
        /// </summary>
        public GetBrandingOKResponse(string activationSubtitle = default(string), string activationTitle = default(string), string contactUsText = default(string), string copyrightText = default(string), string documentationUrl = default(string), GetBrandingOKResponseEmails emails = default(GetBrandingOKResponseEmails), string favicon = default(string), string forumUrl = default(string), string homePage = default(string), GetBrandingOKResponseHomePageConfig homePageConfig = default(GetBrandingOKResponseHomePageConfig), string loginSubtitle = default(string), string loginTitle = default(string), GetBrandingOKResponseLogo logo = default(GetBrandingOKResponseLogo), string pageTitle = default(string), bool? poweredBySisense = default(bool?))
        {
            ActivationSubtitle = activationSubtitle;
            ActivationTitle = activationTitle;
            ContactUsText = contactUsText;
            CopyrightText = copyrightText;
            DocumentationUrl = documentationUrl;
            Emails = emails;
            Favicon = favicon;
            ForumUrl = forumUrl;
            HomePage = homePage;
            HomePageConfig = homePageConfig;
            LoginSubtitle = loginSubtitle;
            LoginTitle = loginTitle;
            Logo = logo;
            PageTitle = pageTitle;
            PoweredBySisense = poweredBySisense;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activationSubtitle")]
        public string ActivationSubtitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activationTitle")]
        public string ActivationTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactUsText")]
        public string ContactUsText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "copyrightText")]
        public string CopyrightText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentationUrl")]
        public string DocumentationUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emails")]
        public GetBrandingOKResponseEmails Emails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "favicon")]
        public string Favicon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "forumUrl")]
        public string ForumUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "homePage")]
        public string HomePage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "homePageConfig")]
        public GetBrandingOKResponseHomePageConfig HomePageConfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "loginSubtitle")]
        public string LoginSubtitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "loginTitle")]
        public string LoginTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logo")]
        public GetBrandingOKResponseLogo Logo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageTitle")]
        public string PageTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "poweredBySisense")]
        public bool? PoweredBySisense { get; set; }

    }
}
