Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

// F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
// S: Bird.cs

// F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// S: Animal.cs

var animals = new List<Animal>
{
	new Dog("Sally", 9, 24, "Gray", MoodLevel.Happy, Gender.Female),
	new Dog("Frank", 5, 14, "Brown", MoodLevel.Happy, Gender.Male),
	new Pelican("Paul", 7, 13, "White", MoodLevel.Alert, Gender.Male, wingspan: 300),
	new Flamingo("Klaus", 4, 4, "Pink", MoodLevel.Calm, Gender.Male, wingspan: 90),
	new Wolf("Bethany", 7, 43, "Gray", MoodLevel.Cautious, Gender.Female, speed: 60),
	new Hedgehog("Moe", 2, 0.7, "Light brown", MoodLevel.Sleepy, Gender.Male, amountOfSpikes: 5000),
	new Swan("Vic", 3, 8, "White", MoodLevel.Calm, Gender.Female, wingspan: 200, inRelationship: true),
	new Horse("Deborah", 17, 600, "White", MoodLevel.Excited, Gender.Female),
	new Worm("William", 1, 0.1, "Beige", MoodLevel.Happy, Gender.Male, length: 10),
	new Wolfman("Jack", 150, 90, "Black", MoodLevel.Brooding, Gender.Male, 15, weaponOfChoice: "Claws"),
};

foreach (var animal in animals)
{
    Console.WriteLine(animal.Stats());

	var last = animals.Last();
	if (!animal.Equals(last))
	{
        Console.WriteLine();
    }
}

Console.ReadKey();