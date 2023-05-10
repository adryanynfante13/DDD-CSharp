using person.DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.Repositories
{
    public interface IAddressRepository
    {
        Task AddAddress(Address ToSave);
    }
}
