using AutoMapper;
using Customerinfo.Customers;

namespace Customerinfo;

public class CustomerinfoApplicationAutoMapperProfile : Profile
{
    public CustomerinfoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
         CreateMap<Customer, CustomerDto>().ReverseMap();
    }
}
