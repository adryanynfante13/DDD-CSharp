using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.ValueObjects
{
    public record AddressLinel
    {
        public AddressLinel() { }

        public string Value { get; init; }

        internal AddressLinel(string value)
        {
            Value = value;
        }
        public static AddressLinel Create(string value)
        {
            validate(value);
            return new AddressLinel(value);
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
