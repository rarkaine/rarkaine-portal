using System.Threading.Tasks;
using Abp.Application.Services;

namespace Rarkaine.Portal.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
