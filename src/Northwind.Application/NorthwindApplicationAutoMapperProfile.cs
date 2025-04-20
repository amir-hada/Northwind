using AutoMapper;
using Northwind.Sample;

namespace Northwind;

public class NorthwindApplicationAutoMapperProfile : Profile
{
    public NorthwindApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Alphabetical_list_of_product, Alphabetical_list_of_productDto>();

    }
}
