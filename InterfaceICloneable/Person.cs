using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceICloneable
{
    class Person : ICloneable
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

        public object Clone()
        {
            return new Person(Name, Surnames, Age);
        }

        public override string ToString()
        {
            return $"Person(Name: {Name}, Surnames: {Surnames}, Age: {Age})";
        }
    }
}
