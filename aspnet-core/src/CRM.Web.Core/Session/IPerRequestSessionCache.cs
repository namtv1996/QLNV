using System.Threading.Tasks;
using CRM.Sessions.Dto;

namespace CRM.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
