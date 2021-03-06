﻿using System;
using System.Threading.Tasks;
using LiberisLabs.CompaniesHouse.Response.CompanyFiling;
using NUnit.Framework;

namespace LiberisLabs.CompaniesHouse.IntegrationTests.Tests.CompanyFilingHistoryTests
{
    public abstract class CompanyFilingHistoryTestBase
    {
        protected CompaniesHouseClient _client;

        [SetUp]
        public async Task Setup()
        {
            GivenACompaniesHouseClient();
            await When().ConfigureAwait(false);
        }

        protected abstract Task When();

        private void GivenACompaniesHouseClient()
        {
            var apiKey = Environment.GetEnvironmentVariable("CompaniesHouseApiKey");
            var settings = new CompaniesHouseSettings(apiKey);
            _client = new CompaniesHouseClient(settings);
        }
    }
}
