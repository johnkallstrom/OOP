Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

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

Console.ReadKey();