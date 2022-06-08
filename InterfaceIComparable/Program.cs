using InterfaceICloneable;

Person person1 = new Person("CFernando", "Carrillo", 18);
Person person2 = new Person("AJuan", "Carrillo", 18);
Person person3 = new Person("DFrank", "Carrillo", 18);
Person person4 = new Person("BMike", "Carrillo", 18);

Person[] people = new Person[] { person1, person2, person3, person4 };

foreach (var item in people)
{
    Console.WriteLine(item);
}

Array.Sort(people);
Console.WriteLine("--------------------------------");

foreach (var item in people)
{
    Console.WriteLine(item);
}
