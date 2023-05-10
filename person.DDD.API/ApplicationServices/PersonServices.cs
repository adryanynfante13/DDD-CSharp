using person.DDD.API.Commands;
using person.DDD.API.Queries;
using person.DDD.Domain.DomainEvents;
using person.DDD.Domain.Entities;
using person.DDD.Domain.Repositories;
using person.DDD.Domain.ValueObjects;

namespace person.DDD.API.ApplicationServices
{
    public class PersonServices
    {
        private readonly IPersonRepository repository;
        private readonly PersonQueries personQueries;
        private IAddressRepository addressRepository;

        public PersonServices(IPersonRepository repository, PersonQueries personQueries, IAddressRepository addressRepository) 
        { 
            this.repository = repository;
            this.personQueries=personQueries;
            this.addressRepository=addressRepository;
            Events.PersonCreated.Register (async (parameter) =>
            {
                var address = new Address(parameter.id);
                address.SetAddressLinel(parameter.AddressLinel);
                address.SetPostalCode(parameter.AddressPostalCode);
                address.SetPersonId(parameter.person);
                await addressRepository.AddAddress(address);
                Console.WriteLine("Ejecución de evento de dominio");
            });
        }
        //controlador del comando
        public async Task HandleCommand(CreatePersonCommand command)
        {
            var person = new Person(PersonId.Create(command.personId));
            person.SetName(PersonName.Create(command.Name));
            await repository.AddPerson(person);
            person.PersonRegistered(command.AddressLine, command.postalCode);
        }
        //invocación  Queries

        public async Task<Person>GetPerson(Guid Id)
        {
            return await personQueries.GetPersonIdAsync(Id);
        }
    }
}
