using System.Threading.Tasks;
using Rarkaine.Portal.Authorization.Users;

namespace Rarkaine.Portal.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
