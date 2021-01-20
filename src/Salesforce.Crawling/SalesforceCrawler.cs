using System;
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
        private int countItems = 0;

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
            foreach (var item in client.Get<Account>("Account", "'0122o0000007pMrAAI'")) //Person
            {
                yield return item;
                countItems++;
            }

            //foreach (var item in client.Get<Account>("Account", "'0121t000000Dy89AAC'")) //Organization
            //{
            //    yield return item;
            //}

            //foreach (var item in client.Get<Contact>("Contact", "'0121t0000010SSoAAM'")) //Organization
            //{
            //    yield return item;
            //}
            Console.WriteLine("Antal records: {0}", countItems);
        }
    }
}
