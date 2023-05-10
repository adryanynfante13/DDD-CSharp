using person.DDD.Domain.DomainEvents;
using person.DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; init; }
        public PersonName Name { get; private set; }
        public List<Address> Addresses { get; set; }

        public Person(Guid id) 
        { 
            this.Id = id;

        }

        public Person()
        {
        }

        public void SetName(PersonName name)
        {
            Name = name;
        }
        /*
         * Metodo logica de negocio
         */
        public void PersonRegistered()
        {
            Events.PersonCreated.Publish(new PersonCreated(Id, Name));
        }
    }
}
