using RetailDataManager.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace RetailDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserInfo(string token);
        HttpClient ApiCLient { get; }
    }
}