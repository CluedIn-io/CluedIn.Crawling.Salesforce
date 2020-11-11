// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the ContactObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Core.Utilities;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class ContactClueProducer : BaseClueProducer<Contact>
    {
        private readonly IClueFactory _factory;

        public ContactClueProducer([NotNull] IClueFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Contact value, Guid id)
        {
            var clue = _factory.Create(EntityType.Infrastructure.Contact, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }

            if (value.Description != null)
                data.Description = value.Description;

            if (value.AccountId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.OwnedBy, value, value.AccountId);
            }

            if (value.CreatedDate != null)
            {
                DateTimeOffset createdDate;
                if (DateTimeOffset.TryParse(value.CreatedDate, out createdDate))
                {
                    data.CreatedDate = createdDate;
                }
            }

            if (value.LastModifiedDate != null)
            {
                DateTimeOffset modifiedDate;
                if (DateTimeOffset.TryParse(value.LastModifiedDate, out modifiedDate))
                {
                    data.ModifiedDate = modifiedDate;
                }
            }
            if (value.CreatedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.CreatedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.CreatedById));
                data.Authors.Add(createdBy);
            }

            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);
            }

            if (value.SystemModstamp != null)
                data.Properties[SalesforceVocabulary.Contact.SystemModstamp] = value.SystemModstamp;

            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Contact.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Contact.ConnectionSentId] = value.ConnectionSentId;
            if (value.IsDeleted != null)
                data.Properties[SalesforceVocabulary.Contact.IsDeleted] = value.IsDeleted;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Contact.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Contact.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.OwnerId != null)
            {
                if (value.OwnerId != value.ID)
                    _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);

                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.RecordTypeId != null)
                data.Properties[SalesforceVocabulary.Contact.RecordTypeId] = value.RecordTypeId;
            if (value.AssistantName != null)
                data.Properties[SalesforceVocabulary.Contact.AssistantName] = value.AssistantName;
            if (value.AssistantPhone != null)
                data.Properties[SalesforceVocabulary.Contact.AssistantPhone] = value.AssistantPhone;
            if (value.Birthdate != null)
                data.Properties[SalesforceVocabulary.Contact.Birthdate] = value.Birthdate;
            if (value.CanAllowPortalSelfReg != null)
                data.Properties[SalesforceVocabulary.Contact.CanAllowPortalSelfReg] = value.CanAllowPortalSelfReg;
            if (value.CleanStatus != null)
                data.Properties[SalesforceVocabulary.Contact.CleanStatus] = value.CleanStatus;
            if (value.ConnectionReceivedId != null)
                data.Properties[SalesforceVocabulary.Contact.ConnectionReceivedId] = value.ConnectionReceivedId;
            if (value.ConnectionSentId != null)
                data.Properties[SalesforceVocabulary.Contact.ConnectionSentId] = value.ConnectionSentId;
            if (value.Department != null)
                data.Properties[SalesforceVocabulary.Contact.Department] = value.Department;
            if (value.DoNotCall != null)
                data.Properties[SalesforceVocabulary.Contact.DoNotCall] = value.DoNotCall;
            if (value.Email != null)
                data.Properties[SalesforceVocabulary.Contact.Email] = value.Email;
            if (value.EmailBouncedDate != null)
                data.Properties[SalesforceVocabulary.Contact.EmailBouncedDate] = DateUtilities.GetFormattedDateString(value.EmailBouncedDate);
            if (value.EmailBouncedReason != null)
                data.Properties[SalesforceVocabulary.Contact.EmailBouncedReason] = value.EmailBouncedReason;
            if (value.Fax != null)
                data.Properties[SalesforceVocabulary.Contact.Fax] = value.Fax;
            if (value.FirstName != null)
                data.Properties[SalesforceVocabulary.Contact.FirstName] = value.FirstName;
            if (value.HasOptedOutOfEmail != null)
                data.Properties[SalesforceVocabulary.Contact.HasOptedOutOfEmail] = value.HasOptedOutOfEmail;
            if (value.HasOptedOutOfFax != null)
                data.Properties[SalesforceVocabulary.Contact.HasOptedOutOfFax] = value.HasOptedOutOfFax;
            if (value.HomePhone != null)
                data.Properties[SalesforceVocabulary.Contact.HomePhone] = value.HomePhone;
            if (value.IsEmailBounced != null)
                data.Properties[SalesforceVocabulary.Contact.IsEmailBounced] = value.IsEmailBounced;
            if (value.IsPersonAccount != null)
                data.Properties[SalesforceVocabulary.Contact.IsPersonAccount] = value.IsPersonAccount;
            if (value.Jigsaw != null)
                data.Properties[SalesforceVocabulary.Contact.Jigsaw] = value.Jigsaw;
            if (value.LastActivityDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            if (value.LastCURequestDate != null)
                data.Properties[SalesforceVocabulary.Contact.LastCURequestDate] = DateUtilities.GetFormattedDateString(value.LastCURequestDate);
            if (value.LastCUUpdateDate != null)
                data.Properties[SalesforceVocabulary.Contact.LastCUUpdateDate] = DateUtilities.GetFormattedDateString(value.LastCUUpdateDate);
            if (value.LastName != null)
                data.Properties[SalesforceVocabulary.Contact.LastName] = value.LastName;
            if (value.LastReferencedDate != null)
                data.Properties[SalesforceVocabulary.Contact.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null)
                data.Properties[SalesforceVocabulary.Contact.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.LeadSource != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.LeadSource);
                data.Properties[SalesforceVocabulary.Contact.LeadSource] = value.LeadSource;
            }

            if (value.MailingAddress != null)
                data.Properties[SalesforceVocabulary.Contact.MailingAddress] = value.MailingAddress;
            if (value.MailingCity != null)
                data.Properties[SalesforceVocabulary.Contact.MailingCity] = value.MailingCity;
            if (value.MailingCountry != null)
                data.Properties[SalesforceVocabulary.Contact.MailingCountry] = value.MailingCountry;
            if (value.MailingCountryCode != null)
                data.Properties[SalesforceVocabulary.Contact.MailingCountryCode] = value.MailingCountryCode;
            if (value.MailingGeocodeAccuracy != null)
                data.Properties[SalesforceVocabulary.Contact.MailingGeocodeAccuracy] = value.MailingGeocodeAccuracy;
            if (value.MailingLatitude != null)
                data.Properties[SalesforceVocabulary.Contact.MailingLatitude] = value.MailingLatitude;
            if (value.MailingLongitude != null)
                data.Properties[SalesforceVocabulary.Contact.MailingLongitude] = value.MailingLongitude;
            if (value.MailingPostalCode != null)
                data.Properties[SalesforceVocabulary.Contact.MailingPostalCode] = value.MailingPostalCode;
            if (value.MailingState != null)
                data.Properties[SalesforceVocabulary.Contact.MailingState] = value.MailingState;
            if (value.MailingStateCode != null)
                data.Properties[SalesforceVocabulary.Contact.MailingStateCode] = value.MailingStateCode;
            if (value.MailingStreet != null)
                data.Properties[SalesforceVocabulary.Contact.MailingStreet] = value.MailingStreet;
            if (value.MasterRecordId != null)
                data.Properties[SalesforceVocabulary.Contact.MasterRecordId] = value.MasterRecordId;
            if (value.MiddleName != null)
                data.Properties[SalesforceVocabulary.Contact.MiddleName] = value.MiddleName;
            if (value.MobilePhone != null)
                data.Properties[SalesforceVocabulary.Contact.MobilePhone] = value.MobilePhone;
            if (value.OtherAddress != null)
                data.Properties[SalesforceVocabulary.Contact.OtherAddress] = value.OtherAddress;
            if (value.OtherCity != null)
                data.Properties[SalesforceVocabulary.Contact.OtherCity] = value.OtherCity;
            if (value.OtherCountry != null)
                data.Properties[SalesforceVocabulary.Contact.OtherCountry] = value.OtherCountry;
            if (value.OtherCountryCode != null)
                data.Properties[SalesforceVocabulary.Contact.OtherCountryCode] = value.OtherCountryCode;
            if (value.OtherGeocodeAccuracy != null)
                data.Properties[SalesforceVocabulary.Contact.OtherGeocodeAccuracy] = value.OtherGeocodeAccuracy;
            if (value.OtherLatitude != null)
                data.Properties[SalesforceVocabulary.Contact.OtherLatitude] = value.OtherLatitude;
            if (value.OtherLongitude != null)
                data.Properties[SalesforceVocabulary.Contact.OtherLongitude] = value.OtherLongitude;
            if (value.OtherPhone != null)
                data.Properties[SalesforceVocabulary.Contact.OtherPhone] = value.OtherPhone;
            if (value.OtherPostalCode != null)
                data.Properties[SalesforceVocabulary.Contact.OtherPostalCode] = value.OtherPostalCode;
            if (value.OtherState != null)
                data.Properties[SalesforceVocabulary.Contact.OtherState] = value.OtherState;
            if (value.OtherStateCode != null)
                data.Properties[SalesforceVocabulary.Contact.OtherStateCode] = value.OtherStateCode;
            if (value.OtherStreet != null)
                data.Properties[SalesforceVocabulary.Contact.OtherStreet] = value.OtherStreet;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.CreatedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.Phone != null)
                data.Properties[SalesforceVocabulary.Contact.Phone] = value.Phone;
            //if (value.PhotoUrl != null)
            //{
            //    if (value.PhotoUrl != null)
            //    {
            //        try
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + state.JobData.Token.AccessToken);
            //                using (var stream = webClient.OpenRead(value.PhotoUrl))
            //                {
            //                    var inArray = StreamUtilies.ReadFully(stream);
            //                    if (inArray != null)
            //                    {
            //                        var rawDataPart = new RawDataPart()
            //                        {
            //                            Type = "/RawData/PreviewImage",
            //                            MimeType = CluedIn.Core.FileTypes.MimeType.Jpeg.Code,
            //                            FileName = "preview_{0}".FormatWith(clue.OriginEntityCode.Key),
            //                            RawDataMD5 = FileHashUtility.GetMD5Base64String(inArray),
            //                            RawData = Convert.ToBase64String(inArray)
            //                        };

            //                        clue.Details.RawData.Add(rawDataPart);

            //                        clue.Data.EntityData.PreviewImage = new ImageReferencePart(rawDataPart);
            //                    }
            //                }
            //            }

            //        }
            //        catch (Exception exception)
            //        {
            //            state.Log.Warn(() => "Could not download Contact Thumbnail Preview from SalesForce.", exception);
            //        }
            //    }
            //}

            if (value.ReportsToId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ManagedBy,
                value, value.ReportsToId);
            }

            if (value.Salutation != null)
                data.Properties[SalesforceVocabulary.Contact.Salutation] = value.Salutation;
            if (value.Suffix != null)
                data.Properties[SalesforceVocabulary.Contact.Suffix] = value.Suffix;
            if (value.Title != null)
                data.Properties[SalesforceVocabulary.Contact.Title] = value.Title;

            //data.Uri = new Uri($"{this.state.JobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Contact.EditUrl] = $"{this.state.JobData.Token.Data}/{value.ID}";

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
