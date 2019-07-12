using System.Threading.Tasks;

namespace CRM.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}