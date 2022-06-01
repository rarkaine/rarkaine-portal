using System.Globalization;

namespace Rarkaine.Portal.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}