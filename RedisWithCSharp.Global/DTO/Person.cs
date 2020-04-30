using System.Collections.Generic;

namespace RedisWithCSharp.Global.DTO
{
    public class Person
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Contact> Contacts { get; set; }

        public Person(long id, string name, List<Contact> contacts)
        {
            Id = id;
            Name = name;
            Contacts = contacts;
        }
    }
}
