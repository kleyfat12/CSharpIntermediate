using InterfaceICloneable;

Person person = new Person("Fernando", "Carrillo", 18);

// This is not a clone
Person person2 = person;

Console.WriteLine(person);
Console.WriteLine(person2);

person.Name = "Juan";

Console.WriteLine(person);
Console.WriteLine(person2);
// person and person2 point to the same memory space

Console.WriteLine("------------------------------------");

person2 = (Person)person.Clone();
// Now person 2 point to a different memory space
Console.WriteLine(person);
Console.WriteLine(person2);

// If I change something in person
person.Name = "Cesar";

// There is no change in person2
Console.WriteLine(person);
Console.WriteLine(person2);
