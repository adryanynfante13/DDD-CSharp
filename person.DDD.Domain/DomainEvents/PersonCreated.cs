﻿using person.DDD.Domain.Entities;
using person.DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.DDD.Domain.DomainEvents
{
    public record PersonCreated(Guid id, PersonName name, Guid idAddress, AddressLinel AddressLinel, AddressPostalCode AddressPostalCode, Person person)
    {

    }
}
