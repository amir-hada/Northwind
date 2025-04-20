using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Northwind.Sample;

public class ProductAppService : ApplicationService, IProductAppService
{
    private readonly ProductManager _productManager;

    public ProductAppService(ProductManager productManager)
    {
        _productManager = productManager;
    }
    
    public async Task<List<Alphabetical_list_of_productDto>> GetListAsync()
    {
        var products = await _productManager.GetProductsAsync();
        return ObjectMapper.Map<List<Alphabetical_list_of_product>, List<Alphabetical_list_of_productDto>>(products);
    }
}