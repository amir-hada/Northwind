using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Northwind.Sample;

public interface IProductRepository : IRepository<Alphabetical_list_of_product, int>
{
    Task<List<Alphabetical_list_of_product>> GetProductsAsync();
}