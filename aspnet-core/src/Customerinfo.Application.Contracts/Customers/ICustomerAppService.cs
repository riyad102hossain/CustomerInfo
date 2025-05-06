using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Customerinfo.Customers; // For CustomerDto
using Volo.Abp.Application.Dtos;

namespace Customerinfo.Customers // Keep consistent with other interfaces/services
{
    public interface ICustomerService
    {
        Task<CustomerDto> CreateAsync(CustomerDto customer);
        Task<CustomerDto> UpdateAsync(CustomerDto customer);
        Task DeleteAsync(Guid id);
        Task<CustomerDto> GetByIdAsync(Guid id);
        Task<List<CustomerDto>> GetListAsync();
    }
}
