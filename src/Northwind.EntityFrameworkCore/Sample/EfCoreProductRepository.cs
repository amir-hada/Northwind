using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Northwind.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Northwind.Sample;

public class EfCoreProductRepository : EfCoreRepository<SampleDbContext, Alphabetical_list_of_product, int>, IProductRepository
{
    public EfCoreProductRepository(IDbContextProvider<SampleDbContext> dbContextProvider) : base(dbContextProvider)
    {
        
    }

    public async Task<List<Alphabetical_list_of_product>> GetProductsAsync()
    {
        return await DbSet.ToListAsync();
    }
    
}