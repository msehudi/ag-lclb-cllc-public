namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;

    public partial class MicrosoftDynamicsCRMadoxioLegalentity
    {

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Account@odata.bind")]
        public string AdoxioAccountValueODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_ShareholderAccountID@odata.bind")]
        public string AdoxioShareholderAccountODataBind { get; set; }

        [JsonProperty(PropertyName = "adoxio_LegalEntityOwned@odata.bind")]
        public string AdoxioLegalEntityOwnedODataBind { get; set; }
    }
}
