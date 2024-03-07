using Encapsulation;

var handler = new PersonHandler();

Person bob = null;

try
{
	bob = handler.CreatePerson(55, "Bob", "Frapples", 188, 81);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


if (bob is not null)
{
	Console.WriteLine(bob.ToString());
}

handler.DeletePerson(bob);

Console.ReadKey();