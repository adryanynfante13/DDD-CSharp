using person.DDD.Domain.Entities;
using person.DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Infrastructure
{
    public class AddressRepository : IAddressRepository
    {
        public Task AddAddress(Address ToSave)
        {
            throw new NotImplementedException();
        }
    }
}
