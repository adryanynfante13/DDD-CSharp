using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.ValueObjects
{
    public record AddressPostalCode
    {
        public AddressPostalCode() { }

        public string Value { get; init; }

        internal AddressPostalCode(string value)
        {
            Value = value;
        }
        public static AddressPostalCode Create(string value)
        {
            validate(value);
            return new AddressPostalCode(value);
        }
        private static void validate(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("el valor no puede ser nulo");
            }
        }
    }
}
