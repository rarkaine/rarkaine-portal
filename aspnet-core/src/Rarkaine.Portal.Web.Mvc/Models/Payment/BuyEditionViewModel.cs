using System.Collections.Generic;
using Rarkaine.Portal.Editions;
using Rarkaine.Portal.Editions.Dto;
using Rarkaine.Portal.MultiTenancy.Payments;
using Rarkaine.Portal.MultiTenancy.Payments.Dto;

namespace Rarkaine.Portal.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
