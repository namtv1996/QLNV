using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace CRM.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
