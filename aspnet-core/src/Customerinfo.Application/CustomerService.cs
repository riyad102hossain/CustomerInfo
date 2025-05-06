
using Customerinfo.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace CustomerApp
{
    public class CustomerService : ApplicationService, ICustomerService, ITransientDependency
    {
        private readonly IRepository<Customer, Guid> _customerRepository;

        public CustomerService(IRepository<Customer, Guid> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDto> CreateAsync(CustomerDto customer)
        {
            var customerEntity = ObjectMapper.Map<CustomerDto, Customer>(customer);
            var createdCustomer = await _customerRepository.InsertAsync(customerEntity);
            return ObjectMapper.Map<Customer, CustomerDto>(createdCustomer);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<CustomerDto> GetByIdAsync(Guid id)
        {
            var customerEntity = await _customerRepository.GetAsync(id);
            return ObjectMapper.Map<Customer, CustomerDto>(customerEntity);
        }

        public async Task<List<CustomerDto>> GetListAsync()
        {
            var customerEntities = await _customerRepository.GetListAsync();
            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customerEntities);
        }

        public async Task<CustomerDto> UpdateAsync(CustomerDto customer)
        {
            var existingCustomer = await _customerRepository.GetAsync(customer.Id);
            ObjectMapper.Map(customer, existingCustomer);
            var updatedCustomer = await _customerRepository.UpdateAsync(existingCustomer);
            return ObjectMapper.Map<Customer, CustomerDto>(updatedCustomer);
        }
    }
}
