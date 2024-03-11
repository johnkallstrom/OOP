Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

// F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
// S: Bird.cs

// F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// S: Animal.cs

var dog = new Dog("Loke", age: 8, weight: 13, "Light brown", MoodLevel.Happy);
Console.WriteLine(dog.ToString());
dog.DoSound();
dog.Play();
dog.Sleep();

Console.WriteLine();

var horse = new Horse("Waygon", age: 18, weight: 700, "Black", MoodLevel.Excited);
Console.WriteLine(horse.ToString());
horse.DoSound();
horse.Jump();
horse.Eat("carrots");

Console.WriteLine();

var wolf = new Wolf("Vide", age: 2, weight: 50, "Gray", MoodLevel.Happy, speed: 50);
Console.WriteLine(wolf.ToString());
wolf.DoSound();

Console.WriteLine();

var wolverine = new Wolfman("Jack", age: 161, weight: 101, "Dark", MoodLevel.Alert, speed: 40);
wolverine.Talk();
wolverine.ShapeShift();
wolverine.DoSound();

Console.ReadKey();