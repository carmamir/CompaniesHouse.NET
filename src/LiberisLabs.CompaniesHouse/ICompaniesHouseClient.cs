﻿using LiberisLabs.CompaniesHouse.Response.CompanySearch;
using LiberisLabs.CompaniesHouse.Response.OfficerSearch;

namespace LiberisLabs.CompaniesHouse
{
    public interface ICompaniesHouseClient :
        ICompaniesHouseSearchCompanyClient,
        ICompaniesHouseSearchOfficerClient,
        ICompaniesHouseCompanyProfileClient,
        ICompaniesHouseCompanyFilingHistoryClient,
        ICompaniesHouseOfficersClient
    {

    }
}