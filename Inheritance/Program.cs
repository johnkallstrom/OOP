Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

var animals = new List<Animal>
{
	new Dog("Sally", 9, 24, "Gray", Mood.Happy, Gender.Female, isMixedBreed: true),
	new Flamingo("Klaus", 4, 4, "Pink", Mood.Calm, Gender.Male, wingspan: 90, Species.Greater),
	new Hedgehog("Moe", 2, 0.7, "Light brown", Mood.Sleepy, Gender.Male, amountOfSpikes: 5000),
	new Horse("Deborah", 17, 600, "White", Mood.Excited, Gender.Female, height: 1.5),
	new Pelican("Paul", 7, 13, "White", Mood.Alert, Gender.Male, wingspan: 300, beakLength: 35),
	new Swan("Vic", 3, 8, "White", Mood.Calm, Gender.Female, wingspan: 200, inRelationship: true),
	new Wolf("Bethany", 7, 43, "Gray", Mood.Cautious, Gender.Female, speed: 60),
	new Wolfman("Jack", 150, 90, "Black", Mood.Brooding, Gender.Male, 15, weaponOfChoice: "Claws"),
	new Worm("William", 1, 0.1, "Beige", Mood.Happy, Gender.Male, length: 10),
};

foreach (var animal in animals)
{
	Console.WriteLine(animal.Stats());
	Console.Write("Sound: ");
	animal.DoSound();

	if (animal is IPerson)
	{
		var wolfman = animal as Wolfman;
		wolfman.Talk();
	}

	if (animal is Dog)
	{
		var dog = animal as Dog;
		string toy = dog.Toy();
        Console.WriteLine($"Favorite toy: {toy}");
    }

	// Skippa mellanrum efter sista objektet i listan
	var last = animals.Last();
	if (!animal.Equals(last))
	{
		Console.WriteLine();
	}
}

Console.WriteLine();

foreach (var animal in animals)
{
	if (animal is Dog)
	{
		var dog = animal as Dog;
		Console.WriteLine(dog.Stats());
		Console.Write("Sound: ");
		dog.DoSound();
	}
}

var dogs = new List<Dog>();
//dogs.Add(new Horse("Sample Name", 5, 756, "Red", Mood.Excited, Gender.Male, height: 1.5));

Console.ReadKey();