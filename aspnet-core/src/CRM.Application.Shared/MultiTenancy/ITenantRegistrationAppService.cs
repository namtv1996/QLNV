using System.Threading.Tasks;
using Abp.Application.Services;
using CRM.Editions.Dto;
using CRM.MultiTenancy.Dto;

namespace CRM.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}