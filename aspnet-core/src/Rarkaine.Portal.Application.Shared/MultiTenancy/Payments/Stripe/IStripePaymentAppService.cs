using System.Threading.Tasks;
using Abp.Application.Services;
using Rarkaine.Portal.MultiTenancy.Payments.Dto;
using Rarkaine.Portal.MultiTenancy.Payments.Stripe.Dto;

namespace Rarkaine.Portal.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}