using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Northwind.Sample;

public interface IProductAppService : IApplicationService
{
    Task<List<Alphabetical_list_of_productDto>> GetListAsync();
}