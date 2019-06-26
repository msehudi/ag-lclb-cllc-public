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
    /// adoxio_applicationtype
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioApplicationtype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioApplicationtype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioApplicationtype(System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), bool? adoxioIsshowpropertydetails = default(bool?), int? statuscode = default(int?), bool? adoxioIsshowcurrentproperty = default(bool?), string _createdbyValue = default(string), string _owningteamValue = default(string), long? versionnumber = default(long?), string _owneridValue = default(string), bool? adoxioIsshowassociatesformupload = default(bool?), string adoxioDefaultbpfid = default(string), bool? adoxioIsshowhoursofsale = default(bool?), string adoxioDefaultbpmid = default(string), string _owningbusinessunitValue = default(string), bool? adoxioIsshowdeclarations = default(bool?), int? adoxioCategory = default(int?), bool? adoxioIsshowsupportingdocuments = default(bool?), string adoxioActiontext = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _adoxioApplicationfeeproductValue = default(string), int? timezoneruleversionnumber = default(int?), string adoxioApplicationtypeid = default(string), int? utcconversiontimezonecode = default(int?), bool? adoxioIslockestablishmentname = default(bool?), string _owninguserValue = default(string), int? statecode = default(int?), bool? adoxioIsshowfinancialintegrityformupload = default(bool?), string adoxioTitletext = default(string), string adoxioName = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _modifiedbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioApplicationtypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationtypeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioApplicationtypeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioApplicationtypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioApplicationtypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioApplicationtypeApplications = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicencetype> adoxioLicencetypesApplicationtypes = default(IList<MicrosoftDynamicsCRMadoxioLicencetype>), IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent> adoxioApplicationtypeAdoxioApplicationtypecontentApplicationType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent>), MicrosoftDynamicsCRMproduct adoxioApplicationFeeProduct = default(MicrosoftDynamicsCRMproduct))
        {
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            AdoxioIsshowpropertydetails = adoxioIsshowpropertydetails;
            Statuscode = statuscode;
            AdoxioIsshowcurrentproperty = adoxioIsshowcurrentproperty;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            AdoxioIsshowassociatesformupload = adoxioIsshowassociatesformupload;
            AdoxioDefaultbpfid = adoxioDefaultbpfid;
            AdoxioIsshowhoursofsale = adoxioIsshowhoursofsale;
            AdoxioDefaultbpmid = adoxioDefaultbpmid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioIsshowdeclarations = adoxioIsshowdeclarations;
            AdoxioCategory = adoxioCategory;
            AdoxioIsshowsupportingdocuments = adoxioIsshowsupportingdocuments;
            AdoxioActiontext = adoxioActiontext;
            Createdon = createdon;
            this._adoxioApplicationfeeproductValue = _adoxioApplicationfeeproductValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioApplicationtypeid = adoxioApplicationtypeid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioIslockestablishmentname = adoxioIslockestablishmentname;
            this._owninguserValue = _owninguserValue;
            Statecode = statecode;
            AdoxioIsshowfinancialintegrityformupload = adoxioIsshowfinancialintegrityformupload;
            AdoxioTitletext = adoxioTitletext;
            AdoxioName = adoxioName;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioApplicationtypeSyncErrors = adoxioApplicationtypeSyncErrors;
            AdoxioApplicationtypeDuplicateMatchingRecord = adoxioApplicationtypeDuplicateMatchingRecord;
            AdoxioApplicationtypeDuplicateBaseRecord = adoxioApplicationtypeDuplicateBaseRecord;
            AdoxioApplicationtypeAsyncOperations = adoxioApplicationtypeAsyncOperations;
            AdoxioApplicationtypeBulkDeleteFailures = adoxioApplicationtypeBulkDeleteFailures;
            AdoxioApplicationtypeApplications = adoxioApplicationtypeApplications;
            AdoxioLicencetypesApplicationtypes = adoxioLicencetypesApplicationtypes;
            AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType = adoxioApplicationtypeAdoxioApplicationtypecontentApplicationType;
            AdoxioApplicationFeeProduct = adoxioApplicationFeeProduct;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowpropertydetails")]
        public bool? AdoxioIsshowpropertydetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowcurrentproperty")]
        public bool? AdoxioIsshowcurrentproperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowassociatesformupload")]
        public bool? AdoxioIsshowassociatesformupload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpfid")]
        public string AdoxioDefaultbpfid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowhoursofsale")]
        public bool? AdoxioIsshowhoursofsale { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_defaultbpmid")]
        public string AdoxioDefaultbpmid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowdeclarations")]
        public bool? AdoxioIsshowdeclarations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_category")]
        public int? AdoxioCategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowsupportingdocuments")]
        public bool? AdoxioIsshowsupportingdocuments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_actiontext")]
        public string AdoxioActiontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationfeeproduct_value")]
        public string _adoxioApplicationfeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtypeid")]
        public string AdoxioApplicationtypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_islockestablishmentname")]
        public bool? AdoxioIslockestablishmentname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isshowfinancialintegrityformupload")]
        public bool? AdoxioIsshowfinancialintegrityformupload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_titletext")]
        public string AdoxioTitletext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_applicationtype_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioApplicationtypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationtypeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioApplicationtypeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioApplicationtypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioApplicationtypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_applications")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioApplicationtypeApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypes_applicationtypes")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetype> AdoxioLicencetypesApplicationtypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationtype_adoxio_applicationtypecontent_ApplicationType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtypecontent> AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioApplicationFeeProduct { get; set; }

    }
}
