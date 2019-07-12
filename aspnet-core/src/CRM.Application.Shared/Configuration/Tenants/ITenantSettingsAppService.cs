using System.Threading.Tasks;
using Abp.Application.Services;
using CRM.Configuration.Tenants.Dto;

namespace CRM.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
