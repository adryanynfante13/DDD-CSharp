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
        private readonly DataBaseContext context;
        public AddressRepository(DataBaseContext context)
        {
            this.context = context; 
        }
        public async Task AddAddress(Address ToSave)
        {
            context.Add(ToSave);
            await context.SaveChangesAsync();
        }
    }
}
