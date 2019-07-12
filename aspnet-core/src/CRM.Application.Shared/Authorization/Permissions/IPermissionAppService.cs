using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CRM.Authorization.Permissions.Dto;

namespace CRM.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
