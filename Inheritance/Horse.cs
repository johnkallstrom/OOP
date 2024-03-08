namespace Inheritance
{
	internal class Horse : Animal
	{
		public Horse(string name, int age, double weight, string color, MoodLevel mood) : base(name, age, weight, color, mood)
		{
		}

		public override void DoSound() => Console.WriteLine("Neigh! Neigh! Neigh!");
	}
 }
