using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
