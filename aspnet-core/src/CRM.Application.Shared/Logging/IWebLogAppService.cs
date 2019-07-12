using Abp.Application.Services;
using CRM.Dto;
using CRM.Logging.Dto;

namespace CRM.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
