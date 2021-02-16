// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountObserver.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   Defines the AccountObserver type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Vocabularies;
using CluedIn.Core.Utilities;

namespace CluedIn.Crawling.Salesforce.Subjects
{
    public class AccountClueProducer : BaseClueProducer<Account>
    {
        private readonly IClueFactory _factory;

        public AccountClueProducer([NotNull] IClueFactory factory)
            
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        protected override Clue MakeClueImpl(Account value, Guid id)
        {
            var clue = _factory.Create(EntityType.Organization, value.ID, id);
            var data = clue.Data.EntityData;

            if (value.Name != null)
            {
                data.Name = value.Name;
                data.DisplayName = value.Name;
            }


            // TODO: Could this fail? Is this the right name of the JobData?
            //data.Uri = new Uri($"{_jobData.Token.Data}/{value.ID}");
            //data.Properties[SalesforceVocabulary.Account.EditUrl] = $"{_jobData.Token.Data}/{value.ID}";

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

                data.LastChangedBy = createdBy;
            }

            if (value.LastModifiedById != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.ModifiedBy, value, value.LastModifiedById);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.LastModifiedById));
                data.Authors.Add(createdBy);

                data.LastChangedBy = createdBy;
            }

            if (value.SystemModstamp != null) data.Properties[SalesforceVocabulary.Account.SystemModstamp] = value.SystemModstamp;
            if (value.AccountNumber != null) data.Properties[SalesforceVocabulary.Account.AccountNumber] = value.AccountNumber;
            if (value.AccountSource != null) data.Properties[SalesforceVocabulary.Account.AccountSource] = value.AccountSource;
            if (value.AnnualRevenue != null) data.Properties[SalesforceVocabulary.Account.AnnualRevenue] = value.AnnualRevenue;
            if (value.BillingCity != null)
            {
                data.Properties[SalesforceVocabulary.Account.BillingCity] = value.BillingCity;
            }
            if (value.BillingCountry != null) data.Properties[SalesforceVocabulary.Account.BillingCountry] = value.BillingCountry;
            if (value.BillingLatitude != null) data.Properties[SalesforceVocabulary.Account.BillingLatitude] = value.BillingLatitude;
            if (value.BillingLongitude != null) data.Properties[SalesforceVocabulary.Account.BillingLongitude] = value.BillingLongitude;
            if (value.BillingPostalCode != null) data.Properties[SalesforceVocabulary.Account.BillingPostalCode] = value.BillingPostalCode;
            if (value.BillingState != null) data.Properties[SalesforceVocabulary.Account.BillingState] = value.BillingState;
            if (value.BillingStreet != null) data.Properties[SalesforceVocabulary.Account.BillingStreet] = value.BillingStreet;
            if (value.CleanStatus != null)
            {
                data.Properties[SalesforceVocabulary.Account.CleanStatus] = value.CleanStatus;
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.CleanStatus);
                data.Tags.Add(new Tag(value.CleanStatus));
            }
            if (value.Description != null)
            {
                data.Description = value.Description;
            }

            if (value.DunsNumber != null) data.Properties[SalesforceVocabulary.Account.DunsNumber] = value.DunsNumber;
            if (value.Fax != null) data.Properties[SalesforceVocabulary.Account.Fax] = value.Fax;
            if (value.Industry != null) data.Properties[SalesforceVocabulary.Account.Industry] = value.Industry;
            if (value.IsDeleted != null) data.Properties[SalesforceVocabulary.Account.IsDeleted] = value.IsDeleted;
            if (value.Jigsaw != null) data.Properties[SalesforceVocabulary.Account.Jigsaw] = value.Jigsaw;
            if (value.LastActivityDate != null)
            {
                DateTime modifiedDateTime;
                if (DateTime.TryParse(value.LastActivityDate, out modifiedDateTime))
                {
                    data.ModifiedDate = modifiedDateTime;
                }
            }

            if (value.LastReferencedDate != null) data.Properties[SalesforceVocabulary.Account.LastReferencedDate] = DateUtilities.GetFormattedDateString(value.LastReferencedDate);
            if (value.LastViewedDate != null) data.Properties[SalesforceVocabulary.Account.LastViewedDate] = DateUtilities.GetFormattedDateString(value.LastViewedDate);
            if (value.MasterRecordId != null) data.Properties[SalesforceVocabulary.Account.MasterRecordId] = value.MasterRecordId;
            if (value.NaicsCode != null) data.Properties[SalesforceVocabulary.Account.NaicsCode] = value.NaicsCode;
            if (value.NaicsDesc != null) data.Properties[SalesforceVocabulary.Account.NaicsDesc] = value.NaicsDesc;
            if (value.NumberOfEmployees != null) data.Properties[SalesforceVocabulary.Account.NumberOfEmployees] = value.NumberOfEmployees;
            if (value.OwnerId != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, value, value.OwnerId);
                var createdBy = new PersonReference(new EntityCode(EntityType.Person, SalesforceConstants.CodeOrigin, value.OwnerId));
                data.Authors.Add(createdBy);
            }

            if (value.Ownership != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Ownership);
                data.Properties[SalesforceVocabulary.Account.Ownership] = value.Ownership;
            }
            if (value.ParentId != null)
            {
                // TODO: This is wrong! ParentId refers to the parent account
                _factory.CreateOutgoingEntityReference(clue, EntityType.Organization, EntityEdgeType.Parent, value, value.ParentId);
            }

            data.Properties[SalesforceVocabulary.Account.Phone] = value.Phone;

            //if (value.PhotoUrl != null)
            //{
            //    if (value.PhotoUrl != null)
            //    {
            //        try
            //        {
            //            using (var webClient = new WebClient())
            //            {
            //                webClient.Headers.Add("Authorization", "Bearer " + _jobData.Token.AccessToken);
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
            //        }
            //    }
            //}

            if (value.Rating != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Rating);
                data.Properties[SalesforceVocabulary.Account.Rating] = value.Rating;
                data.Tags.Add(new Tag(value.Rating));
            }

            if (value.ShippingCity != null) data.Properties[SalesforceVocabulary.Account.ShippingCity] = value.ShippingCity;
            if (value.ShippingCountry != null) data.Properties[SalesforceVocabulary.Account.ShippingCountry] = value.ShippingCountry;
            if (value.ShippingLatitude != null) data.Properties[SalesforceVocabulary.Account.ShippingLatitude] = value.ShippingLatitude;
            if (value.ShippingLongitude != null) data.Properties[SalesforceVocabulary.Account.ShippingLongitude] = value.ShippingLongitude;
            if (value.ShippingPostalCode != null) data.Properties[SalesforceVocabulary.Account.ShippingPostalCode] = value.ShippingPostalCode;
            if (value.ShippingState != null) data.Properties[SalesforceVocabulary.Account.ShippingState] = value.ShippingState;
            if (value.ShippingStreet != null) data.Properties[SalesforceVocabulary.Account.ShippingStreet] = value.ShippingStreet;
            if (value.Sic != null) data.Properties[SalesforceVocabulary.Account.Sic] = value.Sic;
            if (value.SicDesc != null) data.Properties[SalesforceVocabulary.Account.SicDesc] = value.SicDesc;
            if (value.Site != null) data.Properties[SalesforceVocabulary.Account.Site] = value.Site;
            if (value.TickerSymbol != null) data.Properties[SalesforceVocabulary.Account.TickerSymbol] = value.TickerSymbol;
            if (value.Tradestyle != null) data.Properties[SalesforceVocabulary.Account.Tradestyle] = value.Tradestyle;
            if (value.Type != null)
            {
                _factory.CreateOutgoingEntityReference(clue, EntityType.Tag, EntityEdgeType.For, value, value.Type);
                data.Properties[SalesforceVocabulary.Account.Type] = value.Type;
                data.Tags.Add(new Tag(value.Type));
            }

            if (value.Website != null)
            {
                data.Properties[SalesforceVocabulary.Account.Website] = value.Website;

                Uri website;

                if (Uri.TryCreate(value.Website, UriKind.Absolute, out website))
                {
                    data.ExternalReferences.Add(new Uri(value.Website));
                }
            }

            if (value.YearStarted != null) data.Properties[SalesforceVocabulary.Account.YearStarted] = value.YearStarted;

            _factory.CreateEntityRootReference(clue, EntityEdgeType.ManagedIn);

            return clue;
        }
    }
}
