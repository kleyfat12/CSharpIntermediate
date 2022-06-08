using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceICloneable
{
    class Person : IComparable<Person>
    {
        public Person(string name, string surnames, int age)
        {
            Name = name;
            Surnames = surnames;
            Age = age;
        }

        public string Name { get; set; }
        public string Surnames { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person? other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"Person(Name: {Name}, Surnames: {Surnames}, Age: {Age})";
        }
    }
}
