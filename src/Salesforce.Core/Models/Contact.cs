
using System.ComponentModel;

namespace CluedIn.Crawling.Salesforce.Core.Models
{
    [DisplayName("Contact")]
    public class Contact : SystemObject
    {
        public const string SObjectTypeName = "Contact";

        public string AccountId { get; set; }

        [QueryIgnore]
        public string AssistantName { get; set; }

        [QueryIgnore]
        public string AssistantPhone { get; set; }

        [QueryIgnore]
        public string Birthdate { get; set; }

        [QueryIgnore]
        public string CanAllowPortalSelfReg { get; set; }
        [QueryIgnore]
        public string CleanStatus { get; set; }
        [QueryIgnore]
        public string ConnectionReceivedId { get; set; }
        [QueryIgnore]
        public string ConnectionSentId { get; set; }
        [QueryIgnore]
        public string Department { get; set; }
        public string Description { get; set; }
        [QueryIgnore]
        public string DoNotCall { get; set; }
        public string Email { get; set; }
        public string EmailBouncedDate { get; set; }
        public string EmailBouncedReason { get; set; }
        [QueryIgnore]
        public string Fax { get; set; }
        public string FirstName { get; set; }
        [QueryIgnore]
        public string HasOptedOutOfEmail { get; set; }
        [QueryIgnore]
        public string HasOptedOutOfFax { get; set; }
        [QueryIgnore]
        public string HomePhone { get; set; }
        public string IsDeleted { get; set; }
        [QueryIgnore]
        public string IsEmailBounced { get; set; }
        [QueryIgnore]
        public string IsPersonAccount { get; set; }
        public string Jigsaw { get; set; }
        public string LastActivityDate { get; set; }
        public string LastCURequestDate { get; set; }
        public string LastCUUpdateDate { get; set; }
        public string LastName { get; set; }
                [QueryIgnore]
        public string LastReferencedDate { get; set; }
                [QueryIgnore]
        public string LastViewedDate { get; set; }
        public string LeadSource { get; set; }
        [QueryIgnore]
        public string MailingAddress { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingCountry { get; set; }
        public string MailingPostalCode { get; set; }
        [QueryIgnore]
        public string MailingStateCode { get; set; }
        [QueryIgnore]
        public string MailingCountryCode { get; set; }
        public string MailingStreet { get; set; }
        [QueryIgnore]
        public string MailingGeocodeAccuracy { get; set; }
         [QueryIgnore]
        public string MailingLatitude { get; set; }
         [QueryIgnore]
        public string MailingLongitude { get; set; }
        public string MasterRecordId { get; set; }
        [QueryIgnore]
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        [QueryIgnore]
        public string OtherAddress { get; set; }
        public string OtherCity { get; set; }
        public string OtherCountry { get; set; }
        public string OtherPostalCode { get; set; }
        public string OtherState { get; set; }
        [QueryIgnore]
        public string OtherCountryCode { get; set; }
        [QueryIgnore]
        public string OtherStateCode { get; set; }
        [QueryIgnore]
        public string OtherGeocodeAccuracy { get; set; }
          [QueryIgnore]
        public string OtherLatitude { get; set; }
          [QueryIgnore]
        public string OtherLongitude { get; set; }
        public string OtherPhone { get; set; }
        public string OtherStreet { get; set; }
        public string OwnerId { get; set; }
        public string Phone { get; set; }
           [QueryIgnore]
        public string PhotoUrl { get; set; }
        [QueryIgnore]
        public string RecordTypeId { get; set; }
        public string ReportsToId { get; set; }
        public string Salutation { get; set; }
        [QueryIgnore]
        public string Suffix { get; set; }
        public string Title { get; set; }
    }
}
