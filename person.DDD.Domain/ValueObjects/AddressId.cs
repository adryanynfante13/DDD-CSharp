using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.ValueObjects
{
    public record AddressId
    {
        public AddressId() { }

        public Guid value { get; init; }

        internal AddressId(Guid id)
        {
            this.value = id;
        }

        public static AddressId create(Guid value)
        {
            return new AddressId(value);
        }
        public static implicit operator Guid(AddressId personId)
        {
            return personId.value;
        }

    }
}
