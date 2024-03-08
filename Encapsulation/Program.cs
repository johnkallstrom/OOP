using Encapsulation;

void Print(List<Person> people)
{
	if (people.Count() > 0)
	{
		foreach (var person in people)
		{
			Console.WriteLine(person.ToString());
			Console.WriteLine();
		}
	}
}

var handler = new PersonHandler();
var people = new List<Person>();

try
{
	var bob = handler.CreatePerson(55, "Bob", "Frapples", 188, 81);
	var sally = handler.CreatePerson(37, "Sally", "Samson", 167, 65);
	var tom = handler.CreatePerson(45, "Tom", "Jones", 175, 88);
	var susan = handler.CreatePerson(29, "Susan", "Smith", 155, 60);

	people.AddRange([bob, sally, tom, susan]);
	Print(people);
}
catch (ArgumentException ex)
{
	Console.WriteLine(ex.Message);
}

try
{
	foreach (var person in people)
	{
		handler.UpdatePerson(person, 29, "Updated", "Name", 176, 68);
	}

	Print(people);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
	foreach (var person in people)
	{
		handler.DeletePerson(person);
	}
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();