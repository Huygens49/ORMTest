using System;

namespace ORMTest.Entities 
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}