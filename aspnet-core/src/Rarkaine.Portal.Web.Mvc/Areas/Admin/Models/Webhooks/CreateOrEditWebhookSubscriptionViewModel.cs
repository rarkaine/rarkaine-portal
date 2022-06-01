using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Rarkaine.Portal.WebHooks.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
