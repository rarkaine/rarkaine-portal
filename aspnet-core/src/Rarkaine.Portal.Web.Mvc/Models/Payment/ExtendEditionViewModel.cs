using System.Collections.Generic;
using Rarkaine.Portal.Editions.Dto;
using Rarkaine.Portal.MultiTenancy.Payments;

namespace Rarkaine.Portal.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}