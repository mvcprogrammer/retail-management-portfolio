using RetailDataManager.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace RetailDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}