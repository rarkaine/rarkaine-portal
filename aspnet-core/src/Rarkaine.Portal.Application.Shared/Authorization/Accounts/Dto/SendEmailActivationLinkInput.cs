using System.ComponentModel.DataAnnotations;

namespace Rarkaine.Portal.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}