using System.Threading.Tasks;

namespace Rarkaine.Portal.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}