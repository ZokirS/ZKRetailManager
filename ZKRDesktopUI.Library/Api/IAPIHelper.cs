using System.Threading.Tasks;
using ZKRDesktopUI.Models;

namespace ZKRDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}