using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Northwind.Sample;

public class ProductManager : DomainService
{
    private readonly IProductRepository _productRepository;

    public ProductManager(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<List<Alphabetical_list_of_product>> GetProductsAsync()
    {
        return await _productRepository.GetProductsAsync();
    }
}