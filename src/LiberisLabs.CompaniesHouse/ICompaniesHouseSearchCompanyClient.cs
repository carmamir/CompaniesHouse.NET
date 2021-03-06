using System.Threading;
using System.Threading.Tasks;
using LiberisLabs.CompaniesHouse.Request;
using LiberisLabs.CompaniesHouse.Response.CompanySearch;

namespace LiberisLabs.CompaniesHouse
{
    public interface ICompaniesHouseSearchCompanyClient
    {
        Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}