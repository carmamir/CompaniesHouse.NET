using System.Threading;
using System.Threading.Tasks;
using LiberisLabs.CompaniesHouse.Request;
using LiberisLabs.CompaniesHouse.Response.OfficerSearch;

namespace LiberisLabs.CompaniesHouse
{
    public interface ICompaniesHouseSearchOfficerClient
    {
        Task<CompaniesHouseClientResponse<OfficerSearch>> SearchOfficerAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}