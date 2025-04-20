using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Sample;
using Volo.Abp.AspNetCore.Mvc;

namespace Northwind.Controllers.Sample;
[Route("api/sample")]
public class ProductController : AbpController, IProductAppService
{
    private readonly IProductAppService _productAppService;

    public ProductController(IProductAppService productAppService)
    {
        _productAppService = productAppService;
    }
    
    [HttpGet]
    public async Task<List<Alphabetical_list_of_productDto>> GetListAsync()
    {
        return await _productAppService.GetListAsync();
    }
}