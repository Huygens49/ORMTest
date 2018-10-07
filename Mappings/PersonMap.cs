using System;
using ORMTest.Entities;
using FluentNHibernate.Mapping;

namespace ORMTest.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.CreationDate);
            Map(x => x.UpdatedDate);
        }
    }
}