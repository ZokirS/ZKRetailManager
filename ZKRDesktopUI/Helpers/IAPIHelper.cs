using System.Threading.Tasks;
using ZKRDesktopUI.Models;

namespace ZKRDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}