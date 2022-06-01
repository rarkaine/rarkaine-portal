using System.Threading.Tasks;
using Rarkaine.Portal.Sessions.Dto;

namespace Rarkaine.Portal.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
