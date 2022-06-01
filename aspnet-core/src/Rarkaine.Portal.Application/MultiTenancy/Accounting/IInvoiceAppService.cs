using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.MultiTenancy.Accounting.Dto;

namespace Rarkaine.Portal.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
