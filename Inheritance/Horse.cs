namespace Inheritance
{
	internal class Horse : Animal
	{
		public Horse(string name, int age, double weight, string color) : base(name, age, weight, color)
		{
		}

		public override void DoSound() => Console.WriteLine("Neigh! Neigh! Neigh!");
	}
 }
