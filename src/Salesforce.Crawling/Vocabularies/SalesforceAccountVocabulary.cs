// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SalesforceAccountVocabulary.cs" company="Clued In">
//   Copyright Clued In
// </copyright>
// <summary>
//   The salesforce account vocabulary.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Salesforce.Vocabularies
{
    /// <summary>The salesforce account vocabulary.</summary>
    public class SalesforceAccountVocabulary : SimpleVocabulary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceAccountVocabulary"/> class.
        /// </summary>
        public SalesforceAccountVocabulary()
        {
            VocabularyName = "Salesforce Account";
            KeyPrefix      = "salesforce.account";
            KeySeparator   = ".";
            Grouping       = EntityType.Organization;

            AddGroup("Salesforce Account Details", group =>
            {
                SystemModstamp     = group.Add(new VocabularyKey("systemModstamp", VocabularyKeyVisibility.Hidden));
                AccountNumber      = group.Add(new VocabularyKey("accountNumber", VocabularyKeyDataType.Number));
                AccountSource      = group.Add(new VocabularyKey("accountSource"));
                AnnualRevenue      = group.Add(new VocabularyKey("annualRevenue", VocabularyKeyDataType.Money));
                BillingCity        = group.Add(new VocabularyKey("billingCity", VocabularyKeyDataType.GeographyCity));
                BillingCountry     = group.Add(new VocabularyKey("billingCountry", VocabularyKeyDataType.GeographyCountry));
                BillingLatitude    = group.Add(new VocabularyKey("billingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingLongitude   = group.Add(new VocabularyKey("billingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                BillingPostalCode  = group.Add(new VocabularyKey("billingPostalCode"));
                BillingState       = group.Add(new VocabularyKey("billingState"));
                BillingStreet      = group.Add(new VocabularyKey("billingStreet"));
                CleanStatus        = group.Add(new VocabularyKey("cleanStatus"));
                DunsNumber         = group.Add(new VocabularyKey("dunsNumber", VocabularyKeyDataType.Number));
                Fax                = group.Add(new VocabularyKey("fax", VocabularyKeyDataType.PhoneNumber));
                IsDeleted          = group.Add(new VocabularyKey("isDeleted", VocabularyKeyVisibility.Hidden));
                Jigsaw             = group.Add(new VocabularyKey("jigsaw"));
                LastReferencedDate = group.Add(new VocabularyKey("lastReferencedDate", VocabularyKeyVisibility.Hidden));
                LastViewedDate     = group.Add(new VocabularyKey("lastViewedDate", VocabularyKeyDataType.DateTime));
                MasterRecordId     = group.Add(new VocabularyKey("masterRecordId", VocabularyKeyVisibility.Hidden));
                NaicsCode          = group.Add(new VocabularyKey("naicsCode"));
                NaicsDesc          = group.Add(new VocabularyKey("naicsDesc"));
                Ownership          = group.Add(new VocabularyKey("ownership"));
                Rating             = group.Add(new VocabularyKey("rating"));
                ShippingCity       = group.Add(new VocabularyKey("shippingCity", VocabularyKeyDataType.GeographyCity));
                ShippingCountry    = group.Add(new VocabularyKey("shippingCountry", VocabularyKeyDataType.GeographyCountry));
                ShippingLatitude   = group.Add(new VocabularyKey("shippingLatitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingLongitude  = group.Add(new VocabularyKey("shippingLongitude", VocabularyKeyDataType.GeographyCoordinates));
                ShippingPostalCode = group.Add(new VocabularyKey("shippingPostalCode", VocabularyKeyDataType.GeographyLocation));
                ShippingState      = group.Add(new VocabularyKey("shippingState", VocabularyKeyDataType.GeographyLocation));
                ShippingStreet     = group.Add(new VocabularyKey("shippingStreet", VocabularyKeyDataType.GeographyLocation));
                Sic                = group.Add(new VocabularyKey("sic"));
                SicDesc            = group.Add(new VocabularyKey("sicDesc"));
                Site               = group.Add(new VocabularyKey("site"));
                TickerSymbol       = group.Add(new VocabularyKey("tickerSymbol"));
                Tradestyle         = group.Add(new VocabularyKey("tradestyle"));
                Type               = group.Add(new VocabularyKey("type"));
                Website            = group.Add(new VocabularyKey("website", VocabularyKeyDataType.Uri));
                YearStarted        = group.Add(new VocabularyKey("yearStarted", VocabularyKeyDataType.Number));
                Phone              = group.Add(new VocabularyKey("phone", VocabularyKeyDataType.PhoneNumber));
                Industry           = group.Add(new VocabularyKey("industry"));
                NumberOfEmployees  = group.Add(new VocabularyKey("numberOfEmployees", VocabularyKeyDataType.Number));
                EditUrl            = group.Add(new VocabularyKey("editUrl", VocabularyKeyDataType.Uri));
                DomainType = group.Add(new VocabularyKey("domainType"));
            });

            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(Industry,          CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Industry);
            AddMapping(NumberOfEmployees, CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.EmployeeCount);
            AddMapping(Website,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.Website);
            AddMapping(TickerSymbol,      CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.TickerSymbol);
            AddMapping(Sic,               CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.CodesSIC);
            AddMapping(AnnualRevenue,     CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.AnnualRevenue);
            AddMapping(Phone,             CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInOrganization.PhoneNumber);
            AddMapping(EditUrl,           CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInFile.EditUrl);
            AddMapping(SystemModstamp,    CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInDates.ModifiedDate);

            AddMapping(Add(new VocabularyKey("bleanStatus", VocabularyKeyVisibility.Hidden).MarkObsoleteSince(CluedIn.Core.Constants.AppVersion_1_4_2_0)), CleanStatus);
        }

        public VocabularyKey DomainType { get; protected set; }

        public VocabularyKey EditUrl { get; protected set; }
        public VocabularyKey SystemModstamp { get; protected set; }
        public VocabularyKey AccountNumber { get; protected set; }
        public VocabularyKey AccountSource { get; protected set; }
        public VocabularyKey AnnualRevenue { get; protected set; }
        public VocabularyKey BillingCity { get; protected set; }
        public VocabularyKey BillingCountry { get; protected set; }
        public VocabularyKey BillingLatitude { get; protected set; }
        public VocabularyKey BillingLongitude { get; protected set; }
        public VocabularyKey BillingPostalCode { get; protected set; }
        public VocabularyKey BillingState { get; protected set; }
        public VocabularyKey BillingStreet { get; protected set; }
        public VocabularyKey CleanStatus { get; protected set; }
        public VocabularyKey DunsNumber { get; protected set; }
        public VocabularyKey Fax { get; protected set; }
        public VocabularyKey IsDeleted { get; protected set; }
        public VocabularyKey Jigsaw { get; protected set; }
        public VocabularyKey LastReferencedDate { get; protected set; }
        public VocabularyKey LastViewedDate { get; protected set; }
        public VocabularyKey MasterRecordId { get; protected set; }
        public VocabularyKey NaicsCode { get; protected set; }
        public VocabularyKey NaicsDesc { get; protected set; }
        public VocabularyKey Ownership { get; protected set; }
        public VocabularyKey Rating { get; protected set; }
        public VocabularyKey ShippingCity { get; protected set; }
        public VocabularyKey ShippingCountry { get; protected set; }
        public VocabularyKey ShippingLatitude { get; protected set; }
        public VocabularyKey ShippingLongitude { get; protected set; }
        public VocabularyKey ShippingPostalCode { get; protected set; }
        public VocabularyKey ShippingState { get; protected set; }
        public VocabularyKey ShippingStreet { get; protected set; }
        public VocabularyKey Sic { get; protected set; }
        public VocabularyKey SicDesc { get; protected set; }
        public VocabularyKey Site { get; protected set; }
        public VocabularyKey TickerSymbol { get; protected set; }
        public VocabularyKey Tradestyle { get; protected set; }
        public VocabularyKey Type { get; protected set; }
        public VocabularyKey Website { get; protected set; }
        public VocabularyKey YearStarted { get; protected set; }
        public VocabularyKey Phone { get; protected set; }
        public VocabularyKey Industry { get; protected set; }
        public VocabularyKey NumberOfEmployees { get; protected set; }
    }
}
