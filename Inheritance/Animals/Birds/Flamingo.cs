
namespace Inheritance.Animals.Birds
{
	internal class Flamingo : Bird
	{
		public Flamingo(string name, int age, double weight, string color, MoodLevel mood, int wingspan) : base(name, age, weight, color, mood, wingspan)
		{
		}

		public void Dance() => Console.WriteLine($"{GetType().Name} starts dancing!");
	}
}
