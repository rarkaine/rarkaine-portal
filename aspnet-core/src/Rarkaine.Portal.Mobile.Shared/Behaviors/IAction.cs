using Xamarin.Forms.Internals;

namespace Rarkaine.Portal.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}