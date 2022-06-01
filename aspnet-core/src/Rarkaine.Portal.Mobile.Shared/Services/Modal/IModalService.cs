using System.Threading.Tasks;
using Rarkaine.Portal.Views;
using Xamarin.Forms;

namespace Rarkaine.Portal.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
