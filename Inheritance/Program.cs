Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

// F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
// S: Bird

// F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// S: Animal

// F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
// S: Det fungerar inte därför att en häst och en hund är inte samma typ. Häst och hund är två olika subklasser av basklassen Animal

// F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
// S: Animal

// F: Skriv ut samtliga Animals Stats() genom en foreach loop. Förklara vad det är som händer
// S: Listan av animals innehåller olika klasser som alla ärver av basklassen Animal. Foreach-loopen går igenom hela listan och skriver ut statistik för varje djur. 
// Eftersom metoden Stats() finns deklarerad i basklassen Animal så kommer varje subklass åt den (dvs alla djur som ärver av Animal) och vi kan på de sättet skriva ut statistiken för varje djur. 
// I och med att metoden är virtual kan vi också skriva över den i de subklasser där vi vill kanske lägga till lite extra information, specifik för just den klassen/djuret.

// F: Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri sträng. Kommer du åt den metoden från Animals listan?
// S: Nej, eftersom variabeln "animal" i foreach-loopen är av typen Animal och inte Dog så har vi inte tillgång till den metoden.
// Bara de fält, egenskaper och metoder som ligger i Animal klassen kommer vi åt.

var animals = new List<Animal>
{
	new Dog("Sally", 9, 24, "Gray", Mood.Happy, Gender.Female, isMixedBreed: true),
	new Flamingo("Klaus", 4, 4, "Pink", Mood.Calm, Gender.Male, wingspan: 90),
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