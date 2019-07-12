using System.Threading.Tasks;
using Abp.Application.Services;
using CRM.Install.Dto;

namespace CRM.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}