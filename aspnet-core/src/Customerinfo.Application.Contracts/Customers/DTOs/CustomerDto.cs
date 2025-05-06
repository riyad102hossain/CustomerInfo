using System;
using Volo.Abp.Application.Dtos;

namespace Customerinfo.Customers
{
    public class CustomerDto : EntityDto<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
