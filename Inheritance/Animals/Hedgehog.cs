namespace Inheritance.Animals
{
	internal class Hedgehog : Animal
	{
		public Hedgehog(string name, int age, double weight, string color, MoodLevel mood) : base(name, age, weight, color, mood)
		{
		}

		public override void DoSound() => Console.WriteLine("");
	}
}
