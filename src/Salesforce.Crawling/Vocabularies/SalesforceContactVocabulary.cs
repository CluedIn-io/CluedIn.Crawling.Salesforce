// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceContactVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the SalesforceContactVocabulary type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce contact vocabulary</summary>
    /// <seealso cref="CluedIn.CluedIn.Core.Data.Vocabularies.SimpleVocabulary" />
    public class SalesforceContactVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceContactVocabulary"/> class.
        /// </summary>
        public SalesforceContactVocabulary()
        {
            VocabularyName = "Salesforce Contact";
            KeyPrefix      = "salesforce.contact";
            KeySeparator   = ".";
            Grouping       = EntityType.Infrastructure.Contact;

            AddGroup("Salesforce Contact Details", group =>
            {
                SystemModstamp         = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                ConnectionReceivedId   = group.Add(new VocabularyKey("connectionReceivedId", VocabularyKeyVisibility.Hidden));
                ConnectionSentId       = group.Add(new VocabularyKey("connectionSentId", VocabularyKeyVisibility.Hidden));
                IsDeleted              = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                LastReferencedDate     = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyDataType.DateTime));
                LastViewedDate         = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                RecordTypeId           = group.Add(new VocabularyKey("recordTypeId", VocabularyKeyVisibility.Hidden));
                AssistantName          = group.Add(new VocabularyKey("assistantName"));
                AssistantPhone         = group.Add(new VocabularyKey("assistantPhone", VocabularyKeyDataType.PhoneNumber));
                CanAllowPortalSelfReg  = group.Add(new VocabularyKey("canAllowPortalSelfReg", VocabularyKeyDataType.Boolean));
                CleanStatus            = group.Add(new VocabularyKey("cleanStatus"));
                DoNotCall              = group.Add(new VocabularyKey("doNotCall", VocabularyKeyDataType.Boolean));
                EmailBouncedDate       = group.Add(new VocabularyKey("emailBouncedDate", VocabularyKeyDataType.DateTime));
                EmailBouncedReason     = group.Add(new VocabularyKey("emailBouncedReason"));
                Fax                    = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.PhoneNumber));
                HasOptedOutOfEmail     = group.Add(new VocabularyKey("hasOptedOutOfEmail", VocabularyKeyDataType.Boolean));
                HasOptedOutOfFax       = group.Add(new VocabularyKey("hasOptedOutOfFax", VocabularyKeyDataType.Boolean));
                IsEmailBounced         = group.Add(new VocabularyKey("isEmailBounced", VocabularyKeyDataType.Boolean));
                IsPersonAccount        = group.Add(new VocabularyKey("isPersonAccount", VocabularyKeyVisibility.Hidden));
                Jigsaw                 = group.Add(new VocabularyKey("jigsaw"));
                LastCURequestDate      = group.Add(new VocabularyKey("lastCURequestDate", VocabularyKeyDataType.DateTime));
                LastCUUpdateDate       = group.Add(new VocabularyKey("lastCUUpdateDate", VocabularyKeyDataType.DateTime));
                LeadSource             = group.Add(new VocabularyKey("leadSource"));
                MailingCountry         = group.Add(new VocabularyKey("mailingCountry", VocabularyKeyDataType.GeographyCountry));
                MailingGeocodeAccuracy = group.Add(new VocabularyKey("mailingGeocodeAccuracy"));
                MailingLatitude        = group.Add(new VocabularyKey("mailingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                MailingLongitude       = group.Add(new VocabularyKey("mailingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                MailingPostalCode      = group.Add(new VocabularyKey("mailingPostalCode", VocabularyKeyDataType.GeographyLocation));
                MailingStateCode       = group.Add(new VocabularyKey("mailingStateCode", VocabularyKeyDataType.GeographyLocation));
                MasterRecordId         = group.Add(new VocabularyKey("masterRecordId", VocabularyKeyVisibility.Hidden));
                OtherAddress           = group.Add(new VocabularyKey("otherAddress", VocabularyKeyDataType.GeographyLocation));
                OtherCity              = group.Add(new VocabularyKey("otherCity", VocabularyKeyDataType.DateTime));
                OtherCountry           = group.Add(new VocabularyKey("otherCountry", VocabularyKeyDataType.GeographyCity));
                OtherCountryCode       = group.Add(new VocabularyKey("otherCountryCode", VocabularyKeyDataType.GeographyLocation));
                OtherGeocodeAccuracy   = group.Add(new VocabularyKey("otherGeocodeAccuracy", VocabularyKeyDataType.GeographyLocation));
                OtherLatitude          = group.Add(new VocabularyKey("otherLatitude", VocabularyKeyDataType.Number));
                OtherLongitude         = group.Add(new VocabularyKey("otherLongitude", VocabularyKeyDataType.Number));
                OtherPhone             = group.Add(new VocabularyKey("otherPhone", VocabularyKeyDataType.PhoneNumber));
                OtherPostalCode        = group.Add(new VocabularyKey("otherPostalCode", VocabularyKeyDataType.GeographyLocation));
                OtherState             = group.Add(new VocabularyKey("otherState", VocabularyKeyDataType.GeographyLocation));
                OtherStateCode         = group.Add(new VocabularyKey("otherStateCode", VocabularyKeyDataType.GeographyLocation));
                OtherStreet            = group.Add(new VocabularyKey("otherStreet", VocabularyKeyDataType.GeographyLocation));
                Suffix                 = group.Add(new VocabularyKey("suffix"));

                Birthdate              = group.Add(new VocabularyKey("birthdate", VocabularyKeyDataType.DateTime));
                Department             = group.Add(new VocabularyKey("department"));
                Email                  = group.Add(new VocabularyKey("email", VocabularyKeyDataType.Email));
                FirstName              = group.Add(new VocabularyKey("firstName"));
                HomePhone              = group.Add(new VocabularyKey("homePhone", VocabularyKeyDataType.PhoneNumber));
                LastName               = group.Add(new VocabularyKey("lastName"));
                MailingAddress         = group.Add(new VocabularyKey("mailingAddress", VocabularyKeyDataType.GeographyLocation));
                MailingCity            = group.Add(new VocabularyKey("mailingCity", VocabularyKeyDataType.GeographyCity));
                MailingCountryCode     = group.Add(new VocabularyKey("mailingCountryCode", VocabularyKeyDataType.GeographyLocation));
                MailingState           = group.Add(new VocabularyKey("mailingState", VocabularyKeyDataType.GeographyLocation));
                MailingStreet          = group.Add(new VocabularyKey("mailingStreet", VocabularyKeyDataType.GeographyLocation));
                MiddleName             = group.Add(new VocabularyKey("middleName"));
                MobilePhone            = group.Add(new VocabularyKey("mobilePhone", VocabularyKeyDataType.PhoneNumber));
                Phone                  = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber));
                Salutation             = group.Add(new VocabularyKey("salutation"));
                Title                  = group.Add(new VocabularyKey("title"));
            });

            EditUrl = Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(Birthdate,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday);
            AddMapping(Department,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Department);
            AddMapping(Email,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Email);
            AddMapping(FirstName,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.FirstName);
            AddMapping(HomePhone,         CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomePhoneNumber);
            AddMapping(LastName,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.LastName);
            AddMapping(MiddleName,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MiddleName);
            AddMapping(MobilePhone,       CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.MobileNumber);
            AddMapping(Phone,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.PhoneNumber);
            AddMapping(Salutation,        CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Title);
            AddMapping(Title,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.JobTitle);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);
        }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey OtherAddress { get; protected set; }
        public VocabularyKey OtherCity { get; protected set; }
        public VocabularyKey OtherCountry { get; protected set; }
        public VocabularyKey OtherCountryCode { get; protected set; }
        public VocabularyKey OtherGeocodeAccuracy { get; protected set; }
        public VocabularyKey OtherLatitude { get; protected set; }
        public VocabularyKey OtherLongitude { get; protected set; }
        public VocabularyKey OtherPhone { get; protected set; }
        public VocabularyKey OtherPostalCode { get; protected set; }
        public VocabularyKey OtherState { get; protected set; }
        public VocabularyKey OtherStateCode { get; protected set; }
        public VocabularyKey OtherStreet { get; protected set; }
        public VocabularyKey Suffix { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey ConnectionReceivedId { get; protected set; }
        public VocabularyKey ConnectionSentId { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey RecordTypeId { get; protected set; }
        public VocabularyKey AssistantName { get; protected set; }
        public VocabularyKey AssistantPhone { get; protected set; }
        public VocabularyKey CanAllowPortalSelfReg { get; protected set; }
        public VocabularyKey CleanStatus { get; protected set; }
        public VocabularyKey DoNotCall { get; protected set; }
        public VocabularyKey EmailBouncedDate { get; protected set; }
        public VocabularyKey EmailBouncedReason { get; protected set; }
        public VocabularyKey Fax { get; protected set; }
        public VocabularyKey HasOptedOutOfEmail { get; protected set; }
        public VocabularyKey HasOptedOutOfFax { get; protected set; }
        public VocabularyKey IsEmailBounced { get; protected set; }
        public VocabularyKey IsPersonAccount { get; protected set; }
        public VocabularyKey Jigsaw { get; protected set; }
        public VocabularyKey LastCURequestDate { get; protected set; }
        public VocabularyKey LastCUUpdateDate { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey LeadSource { get; protected set; }
        public VocabularyKey MailingCountry { get; protected set; }
        public VocabularyKey MailingGeocodeAccuracy { get; protected set; }
        public VocabularyKey MailingLatitude { get; protected set; }
        public VocabularyKey MailingLongitude { get; protected set; }
        public VocabularyKey MailingPostalCode { get; protected set; }
        public VocabularyKey MailingStateCode { get; protected set; }
        public VocabularyKey MasterRecordId { get; protected set; }
        public VocabularyKey Birthdate          { get; protected set; }
        public VocabularyKey Department         { get; protected set; }
        public VocabularyKey Email              { get; protected set; }
        public VocabularyKey FirstName          { get; protected set; }
        public VocabularyKey HomePhone          { get; protected set; }
        public VocabularyKey LastName           { get; protected set; }
        public VocabularyKey MailingAddress     { get; protected set; }
        public VocabularyKey MailingCity        { get; protected set; }
        public VocabularyKey MailingCountryCode { get; protected set; }
        public VocabularyKey MailingState       { get; protected set; }
        public VocabularyKey MailingStreet      { get; protected set; }
        public VocabularyKey MiddleName         { get; protected set; }
        public VocabularyKey MobilePhone        { get; protected set; }
        public VocabularyKey Phone              { get; protected set; }
        public VocabularyKey Salutation         { get; protected set; }
        public VocabularyKey Title              { get; protected set; }
    }
}