using Encapsulation;

var person = new Person();
person.FirstName = "Bob";
person.LastName = "Frapples";
person.Age = 55;
person.Height = 192;
person.Weight = 75;

Console.WriteLine(person.ToString());
Console.ReadKey();