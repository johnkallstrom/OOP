using Inheritance;
using Inheritance.Enums;

Console.WriteLine("3.3 Inheritance");
Console.WriteLine();

var dog = new Dog("Loke", 8, 13, "Light brown", MoodLevel.Happy);
Console.WriteLine(dog.ToString());
dog.Play();
dog.Sleep();

Console.ReadKey();