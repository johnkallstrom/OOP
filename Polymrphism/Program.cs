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
};

foreach (var error in userErrors)
{
    Console.WriteLine(error.UEMessage());
}

Console.ReadKey();