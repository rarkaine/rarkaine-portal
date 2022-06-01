using System.Threading.Tasks;

namespace Rarkaine.Portal.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}