// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SetBrandingOKResponseLogo
    {
        /// <summary>
        /// Initializes a new instance of the SetBrandingOKResponseLogo class.
        /// </summary>
        public SetBrandingOKResponseLogo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetBrandingOKResponseLogo class.
        /// </summary>
        public SetBrandingOKResponseLogo(SetBrandingOKResponseLogoDesktop desktop = default(SetBrandingOKResponseLogoDesktop), SetBrandingOKResponseLogoPhone phone = default(SetBrandingOKResponseLogoPhone), SetBrandingOKResponseLogoTablet tablet = default(SetBrandingOKResponseLogoTablet))
        {
            Desktop = desktop;
            Phone = phone;
            Tablet = tablet;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "desktop")]
        public SetBrandingOKResponseLogoDesktop Desktop { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public SetBrandingOKResponseLogoPhone Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tablet")]
        public SetBrandingOKResponseLogoTablet Tablet { get; set; }

    }
}
