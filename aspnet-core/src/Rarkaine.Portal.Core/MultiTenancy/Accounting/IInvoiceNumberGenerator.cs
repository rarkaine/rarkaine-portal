using System.Threading.Tasks;
using Abp.Dependency;

namespace Rarkaine.Portal.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}