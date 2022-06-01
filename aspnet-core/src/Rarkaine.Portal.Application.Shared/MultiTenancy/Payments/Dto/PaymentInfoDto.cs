using Rarkaine.Portal.Editions.Dto;

namespace Rarkaine.Portal.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < PortalConsts.MinimumUpgradePaymentAmount;
        }
    }
}
