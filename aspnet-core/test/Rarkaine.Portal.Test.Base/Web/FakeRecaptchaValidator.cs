using System.Threading.Tasks;
using Rarkaine.Portal.Security.Recaptcha;

namespace Rarkaine.Portal.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
