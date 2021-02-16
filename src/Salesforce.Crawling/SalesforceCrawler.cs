using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Salesforce.Core;
using CluedIn.Crawling.Salesforce.Core.Models;
using CluedIn.Crawling.Salesforce.Infrastructure.Factories;

namespace CluedIn.Crawling.Salesforce
{
    public class SalesforceCrawler : ICrawlerDataGenerator
    {
        private readonly ISalesforceClientFactory _clientFactory;

        public SalesforceCrawler(ISalesforceClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is SalesforceCrawlJobData salesforcecrawlJobData))
            {
                yield break;
            }

            var client = _clientFactory.CreateNew(salesforcecrawlJobData);

            //retrieve data from provider and yield objects

            foreach (var item in client.Get<Account>("Account"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Asset>("Asset"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Attachment>("Attachment"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Campaign>("Campaign"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Case>("Case"))
            {
                yield return item;
            }

            foreach (var item in client.Get<CollaborationGroup>("CollaborationGroup"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Company>("Company"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Contact>("Contact"))
            {
                yield return item;
            }

            foreach (var item in client.Get<ContentDocument>("ContentDocument"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Contract>("Contract"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Dashboard>("Dashboard"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Document>("Document"))
            {
                yield return item;
            }

            foreach (var item in client.Get<DomainObject>("Domain"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Event>("Event"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Group>("Group"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Idea>("Idea"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Lead>("Lead"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Network>("Network"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Note>("Note"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Opportunity>("Opportunity"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Order>("Order"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Partner>("Partner"))
            {
                yield return item;
            }

            foreach (var item in client.Get<PriceBook2>("Pricebook"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Product>("Product"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Profile>("Profile"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Quote>("Quote"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Report>("Report"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Site>("Site"))
            {
                yield return item;
            }

            foreach (var item in client.Get<Solution>("Solution"))
            {
                yield return item;
            }

            foreach (var item in client.Get<StreamingChannel>("StreamingChannel"))
            {
                yield return item;
            }

            foreach (var item in client.Get<SalesForceTask>("Task"))
            {
                yield return item;
            }

            foreach (var item in client.Get<User>("User"))
            {
                yield return item;
            }
        }       
    }
}
