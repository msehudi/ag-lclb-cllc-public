// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_worker
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioWorker
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioWorker
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWorker()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMadoxioWorker
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioWorker(int? adoxioGendercode = default(int?), string _adoxioContactidValue = default(string), string adoxioLastname = default(string), string adoxioEmail = default(string), string adoxioDriverslicencenumber = default(string), string adoxioPhonenumber = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? adoxioCurrentaddressdatefrom = default(System.DateTimeOffset?), int? adoxioIsldbworker = default(int?), string _createdbyValue = default(string), System.DateTimeOffset? adoxioDateofbirth = default(System.DateTimeOffset?), int? statuscode = default(int?), long? versionnumber = default(long?), string adoxioBcidcardnumber = default(string), string _adoxioInvoiceValue = default(string), string adoxioMiddlename = default(string), string adoxioName = default(string), int? adoxioInvoicetrigger = default(int?), int? importsequencenumber = default(int?), int? adoxioPaymentreceived = default(int?), string adoxioWorkerid = default(string), int? adoxioSelfdisclosure = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioPaymentreceiveddate = default(System.DateTimeOffset?), string adoxioBirthplace = default(string), string adoxioFirstname = default(string), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), int? statecode = default(int?), int? utcconversiontimezonecode = default(int?), int? adoxioTriggerphs = default(int?), string _owninguserValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMinvoice adoxioInvoice = default(MicrosoftDynamicsCRMinvoice), IList<MicrosoftDynamicsCRMadoxioWorkerinvoicehistory> adoxioWorkerAdoxioWorkerinvoicehistoryWorker = default(IList<MicrosoftDynamicsCRMadoxioWorkerinvoicehistory>), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioWorkerSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioWorkerDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioWorkerDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioWorkerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioWorkerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMcontact adoxioContactId = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMadoxioAlias> adoxioWorkerAliases = default(IList<MicrosoftDynamicsCRMadoxioAlias>), IList<MicrosoftDynamicsCRMadoxioPreviousaddress> adoxioWorkerPreviousaddresses = default(IList<MicrosoftDynamicsCRMadoxioPreviousaddress>), IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> adoxioWorkerregistrationPersonalhistorysummary = default(IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary>))
        {
            AdoxioGendercode = adoxioGendercode;
            this._adoxioContactidValue = _adoxioContactidValue;
            AdoxioLastname = adoxioLastname;
            AdoxioEmail = adoxioEmail;
            AdoxioDriverslicencenumber = adoxioDriverslicencenumber;
            AdoxioPhonenumber = adoxioPhonenumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioCurrentaddressdatefrom = adoxioCurrentaddressdatefrom;
            AdoxioIsldbworker = adoxioIsldbworker;
            this._createdbyValue = _createdbyValue;
            AdoxioDateofbirth = adoxioDateofbirth;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            AdoxioBcidcardnumber = adoxioBcidcardnumber;
            this._adoxioInvoiceValue = _adoxioInvoiceValue;
            AdoxioMiddlename = adoxioMiddlename;
            AdoxioName = adoxioName;
            AdoxioInvoicetrigger = adoxioInvoicetrigger;
            Importsequencenumber = importsequencenumber;
            AdoxioPaymentreceived = adoxioPaymentreceived;
            AdoxioWorkerid = adoxioWorkerid;
            AdoxioSelfdisclosure = adoxioSelfdisclosure;
            Overriddencreatedon = overriddencreatedon;
            AdoxioPaymentreceiveddate = adoxioPaymentreceiveddate;
            AdoxioBirthplace = adoxioBirthplace;
            AdoxioFirstname = adoxioFirstname;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            this._owningteamValue = _owningteamValue;
            Statecode = statecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioTriggerphs = adoxioTriggerphs;
            this._owninguserValue = _owninguserValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            AdoxioInvoice = adoxioInvoice;
            AdoxioWorkerAdoxioWorkerinvoicehistoryWorker = adoxioWorkerAdoxioWorkerinvoicehistoryWorker;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioWorkerSyncErrors = adoxioWorkerSyncErrors;
            AdoxioWorkerDuplicateMatchingRecord = adoxioWorkerDuplicateMatchingRecord;
            AdoxioWorkerDuplicateBaseRecord = adoxioWorkerDuplicateBaseRecord;
            AdoxioWorkerAsyncOperations = adoxioWorkerAsyncOperations;
            AdoxioWorkerBulkDeleteFailures = adoxioWorkerBulkDeleteFailures;
            AdoxioContactId = adoxioContactId;
            AdoxioWorkerAliases = adoxioWorkerAliases;
            AdoxioWorkerPreviousaddresses = adoxioWorkerPreviousaddresses;
            AdoxioWorkerregistrationPersonalhistorysummary = adoxioWorkerregistrationPersonalhistorysummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gendercode")]
        public int? AdoxioGendercode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public string _adoxioContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastname")]
        public string AdoxioLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicencenumber")]
        public string AdoxioDriverslicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_currentaddressdatefrom")]
        public System.DateTimeOffset? AdoxioCurrentaddressdatefrom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isldbworker")]
        public int? AdoxioIsldbworker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateofbirth")]
        public System.DateTimeOffset? AdoxioDateofbirth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcidcardnumber")]
        public string AdoxioBcidcardnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_invoice_value")]
        public string _adoxioInvoiceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_invoicetrigger")]
        public int? AdoxioInvoicetrigger { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentreceived")]
        public int? AdoxioPaymentreceived { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_workerid")]
        public string AdoxioWorkerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_selfdisclosure")]
        public int? AdoxioSelfdisclosure { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentreceiveddate")]
        public System.DateTimeOffset? AdoxioPaymentreceiveddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthplace")]
        public string AdoxioBirthplace { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_triggerphs")]
        public int? AdoxioTriggerphs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Invoice")]
        public MicrosoftDynamicsCRMinvoice AdoxioInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_adoxio_workerinvoicehistory_Worker")]
        public IList<MicrosoftDynamicsCRMadoxioWorkerinvoicehistory> AdoxioWorkerAdoxioWorkerinvoicehistoryWorker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioWorkerSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioWorkerDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioWorkerDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioWorkerAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioWorkerBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContactId")]
        public MicrosoftDynamicsCRMcontact AdoxioContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_aliases")]
        public IList<MicrosoftDynamicsCRMadoxioAlias> AdoxioWorkerAliases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_worker_previousaddresses")]
        public IList<MicrosoftDynamicsCRMadoxioPreviousaddress> AdoxioWorkerPreviousaddresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_workerregistration_personalhistorysummary")]
        public IList<MicrosoftDynamicsCRMadoxioPersonalhistorysummary> AdoxioWorkerregistrationPersonalhistorysummary { get; set; }

    }
}
