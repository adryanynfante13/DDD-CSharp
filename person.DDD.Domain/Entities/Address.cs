using person.DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; init; }
        public AddressLinel AddressLinel { get; private set; }
        public AddressPostalCode AddressPostalCode { get; private set; }
        public Guid PersonId { get; set; }

        public Person Person { get; set; }
        public Address(Guid id) 
        {
            this.Id = id;
        }
        public void SetAddressLinel(AddressLinel name)
        {
            AddressLinel = name;
        }
        public void SetPostalCode(AddressPostalCode name)
        {
            AddressPostalCode = name;
        }
        public void SetPersonId(Person name)
        {
            PersonId = name.Id;
        }
        /*
         * métodos con logica de negocio
         */


    }
}
