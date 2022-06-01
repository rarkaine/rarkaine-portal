using System.Threading.Tasks;
using Abp.Webhooks;

namespace Rarkaine.Portal.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
