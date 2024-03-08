using Polymrphism;

Console.WriteLine("3.2 Polymorphism");
Console.WriteLine();

var userErrors = new List<UserError>
{
	new NumericcInputError(),
	new NumericcInputError(),
	new NumericcInputError(),
	new TextInputError(),
	new TextInputError(),
	new TextInputError(),
	new DateInputError(),
	new DateInputError(),
	new DateInputError(),
	new CharInputError(),
	new CharInputError(),
	new CharInputError(),
};

foreach (var error in userErrors)
{
    Console.WriteLine(error.UEMessage());
}

Console.ReadKey();