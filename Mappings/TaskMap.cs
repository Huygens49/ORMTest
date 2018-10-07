using System;
using ORMTest.Entities;
using FluentNHibernate.Mapping;

namespace ORMTest.Mappings
{
    public class TaskMap : ClassMap<Task>
    {
        public TaskMap()
        {
            Id(x => x.Id);
            Map(x => x.CreationTime);
            Map(x => x.State);
            Map(x => x.Title);
            Map(x => x.Description);
            Map(x => x.UpdatedDate);
            Map(x => x.CreationDate);

            References(x => x.AssignedTo);
        }
    }
}