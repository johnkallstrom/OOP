Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

var dog = new Dog("Loke", age: 8, weight: 13, "Light brown", MoodLevel.Happy);
Console.WriteLine(dog.ToString());
dog.Play();
dog.Sleep();

Console.ReadKey();