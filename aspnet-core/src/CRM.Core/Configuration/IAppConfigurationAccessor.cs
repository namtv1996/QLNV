using Microsoft.Extensions.Configuration;

namespace CRM.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
