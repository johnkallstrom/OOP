using Encapsulation;

var handler = new PersonHandler();
var people = new List<Person>();

try
{
	var bob = handler.CreatePerson(55, "Bob", "Frapples", 188, 81);
	var sally = handler.CreatePerson(37, "Sally", "Samson", 167, 65);

	people.AddRange([bob, sally]);
}
catch (ArgumentException ex)
{
	Console.WriteLine(ex.Message);
}

if (people.Count() > 0)
{
	foreach (var person in people)
	{
		Console.WriteLine(person.ToString());

		if (!people.Last().Equals(person))
		{
			Console.WriteLine();
		}
	}
}

Console.ReadKey();