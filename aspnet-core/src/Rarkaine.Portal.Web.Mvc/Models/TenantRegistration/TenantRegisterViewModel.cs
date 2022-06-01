using Rarkaine.Portal.Editions;
using Rarkaine.Portal.Editions.Dto;
using Rarkaine.Portal.MultiTenancy.Payments;
using Rarkaine.Portal.Security;
using Rarkaine.Portal.MultiTenancy.Payments.Dto;

namespace Rarkaine.Portal.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
