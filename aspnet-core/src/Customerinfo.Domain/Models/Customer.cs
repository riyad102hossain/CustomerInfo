using System;
using Volo.Abp.Domain.Entities;

namespace Customerinfo.Customers
{
    public class Customer: AggregateRoot<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
    }
}