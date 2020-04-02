﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MaraCrawlerNet;
//
//    var mara = Mara.FromJson(jsonString);

namespace MaraCrawlerNet
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Mara
    {
        [JsonProperty("Result")]
        public List<Result> Result { get; set; }

        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("DelimitedStartWithLetterResult")]
        public DelimitedStartWithLetterResult DelimitedStartWithLetterResult { get; set; }
    }

    public partial class DelimitedStartWithLetterResult
    {
        [JsonProperty("FieldName")]
        public string FieldName { get; set; }

        [JsonProperty("Result")]
        public string Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("PrimaryBusiness")]
        public YBusiness PrimaryBusiness { get; set; }

        [JsonProperty("SecondaryBusinesses")]
        public List<YBusiness> SecondaryBusinesses { get; set; }

        [JsonProperty("DisplayBusiness")]
        public YBusiness DisplayBusiness { get; set; }

        [JsonProperty("Name")]
        public Name Name { get; set; }

        [JsonProperty("MARN")]
        public string Marn { get; set; }

        [JsonProperty("IsNoFee")]
        public bool IsNoFee { get; set; }

        [JsonProperty("ContactId")]
        public Guid ContactId { get; set; }

        [JsonProperty("CitizenshipCountries")]
        public List<string> CitizenshipCountries { get; set; }

        [JsonProperty("OtherNames")]
        public List<OtherName> OtherNames { get; set; }

        [JsonProperty("Aliases")]
        public List<string> Aliases { get; set; }

        [JsonProperty("ApplicantReferenceID")]
        public object ApplicantReferenceId { get; set; }

        [JsonProperty("DisplayPublicationDate")]
        public string DisplayPublicationDate { get; set; }

        [JsonProperty("CurrentSanctionOutcome")]
        public CurrentSanctionOutcome CurrentSanctionOutcome { get; set; }

        [JsonProperty("CurrentSanctionOutcome2")]
        public CurrentSanctionOutcome CurrentSanctionOutcome2 { get; set; }

        [JsonProperty("SanctionedDate")]
        public DateTimeOffset? SanctionedDate { get; set; }

        [JsonProperty("DisplaySanctionedDate")]
        public string DisplaySanctionedDate { get; set; }

        [JsonProperty("DisplayCeasedDate")]
        public string DisplayCeasedDate { get; set; }
    }

    public partial class CurrentSanctionOutcome
    {
        [JsonProperty("ContactId")]
        public Guid ContactId { get; set; }

        [JsonProperty("CaseId")]
        public Guid CaseId { get; set; }

        [JsonProperty("CaseOutcomeId")]
        public Guid CaseOutcomeId { get; set; }

        [JsonProperty("CaseOutcomeReferenceNo")]
        public string CaseOutcomeReferenceNo { get; set; }

        [JsonProperty("PrimaryOutcome")]
        public string PrimaryOutcome { get; set; }

        [JsonProperty("PrimaryOutcomeCategory")]
        public string PrimaryOutcomeCategory { get; set; }

        [JsonProperty("DecisionSummary")]
        public string DecisionSummary { get; set; }

        [JsonProperty("DateDecisionMade")]
        public DateTimeOffset DateDecisionMade { get; set; }

        [JsonProperty("DisplayDateDecisionMade")]
        public string DisplayDateDecisionMade { get; set; }

        [JsonProperty("IsCurrent")]
        public bool IsCurrent { get; set; }

        [JsonProperty("DateAppealLodged")]
        public object DateAppealLodged { get; set; }

        [JsonProperty("DisplayDateAppealLodged")]
        public string DisplayDateAppealLodged { get; set; }

        [JsonProperty("Jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonProperty("IsStayDesicionObtained")]
        public bool IsStayDesicionObtained { get; set; }

        [JsonProperty("DateConditionsMet")]
        public object DateConditionsMet { get; set; }

        [JsonProperty("ParentCaseId")]
        public object ParentCaseId { get; set; }

        [JsonProperty("WebPublicationEndDate")]
        public DateTimeOffset WebPublicationEndDate { get; set; }
    }

    public partial class YBusiness
    {
        [JsonProperty("Relationship")]
        public string Relationship { get; set; }

        [JsonProperty("IsPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("IsExisting")]
        public bool IsExisting { get; set; }

        [JsonProperty("CID")]
        public string Cid { get; set; }

        [JsonProperty("CRN")]
        public string Crn { get; set; }

        [JsonProperty("IsProfileLockedOut")]
        public object IsProfileLockedOut { get; set; }

        [JsonProperty("BusinessId")]
        public Guid BusinessId { get; set; }

        [JsonProperty("BusinessClassificationCode")]
        public string BusinessClassificationCode { get; set; }

        [JsonProperty("BusinessClassification")]
        public string BusinessClassification { get; set; }

        [JsonProperty("BusinessType")]
        public string BusinessType { get; set; }

        [JsonProperty("EntityName")]
        public string EntityName { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ABN")]
        public string Abn { get; set; }

        [JsonProperty("Address")]
        public Address Address { get; set; }

        [JsonProperty("PostalAddress")]
        public Address PostalAddress { get; set; }

        [JsonProperty("Contact")]
        public Contact Contact { get; set; }

        [JsonProperty("WebsiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("IsBusinessNameSameAsOwner")]
        public object IsBusinessNameSameAsOwner { get; set; }

        [JsonProperty("IsBusinessNameRegistered")]
        public object IsBusinessNameRegistered { get; set; }

        [JsonProperty("HasHoldingCharge")]
        public object HasHoldingCharge { get; set; }

        [JsonProperty("HasChangesInName")]
        public object HasChangesInName { get; set; }

        [JsonProperty("ChangesInNameDetail")]
        public object ChangesInNameDetail { get; set; }

        [JsonProperty("ConnectedAgents")]
        public List<object> ConnectedAgents { get; set; }

        [JsonProperty("HasEmployees")]
        public object HasEmployees { get; set; }

        [JsonProperty("HavingEmployeesDetail")]
        public object HavingEmployeesDetail { get; set; }

        [JsonProperty("PrimaryContactId")]
        public object PrimaryContactId { get; set; }

        [JsonProperty("VerifiedDocuments")]
        public object VerifiedDocuments { get; set; }

        [JsonProperty("OptionalDocuments")]
        public List<object> OptionalDocuments { get; set; }

        [JsonProperty("OptionalExpiringDocuments")]
        public List<object> OptionalExpiringDocuments { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("AddressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("AddressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("AddressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("OtherState")]
        public string OtherState { get; set; }

        [JsonProperty("Suburb")]
        public string Suburb { get; set; }

        [JsonProperty("OtherSuburb")]
        public string OtherSuburb { get; set; }

        [JsonProperty("PostCode")]
        public string PostCode { get; set; }

        [JsonProperty("OtherPostCode")]
        public string OtherPostCode { get; set; }

        [JsonProperty("Latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("FullAddress")]
        public string FullAddress { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("Phone")]
        public Fax Phone { get; set; }

        [JsonProperty("Phone2")]
        public Fax Phone2 { get; set; }

        [JsonProperty("Phone3")]
        public Fax Phone3 { get; set; }

        [JsonProperty("Fax")]
        public Fax Fax { get; set; }

        [JsonProperty("EmailAddress1")]
        public string EmailAddress1 { get; set; }

        [JsonProperty("EmailAddress2")]
        public object EmailAddress2 { get; set; }
    }

    public partial class Fax
    {
        [JsonProperty("CountryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("AreaCode")]
        public string AreaCode { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("FullNumber")]
        public string FullNumber { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("Salutation")]
        public string Salutation { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("SecondName")]
        public string SecondName { get; set; }

        [JsonProperty("FamilyName")]
        public string FamilyName { get; set; }

        [JsonProperty("PostNominal")]
        public string PostNominal { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }

        [JsonProperty("GivenName")]
        public string GivenName { get; set; }
    }

    public partial class OtherName
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("FamilyName")]
        public string FamilyName { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("SecondName")]
        public string SecondName { get; set; }

        [JsonProperty("Alias")]
        public string Alias { get; set; }

        [JsonProperty("GivenName")]
        public string GivenName { get; set; }
    }

    public partial class Mara
    {
        public static Mara FromJson(string json) => JsonConvert.DeserializeObject<Mara>(json, MaraCrawlerNet.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Mara self) => JsonConvert.SerializeObject(self, MaraCrawlerNet.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
