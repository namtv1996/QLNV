using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using CRM.MultiTenancy.Accounting.Dto;

namespace CRM.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
