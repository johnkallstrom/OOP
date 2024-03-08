namespace Inheritance
{
	internal class Horse : Animal
	{
		public Horse(string name, int age, double weight, string color, MoodLevel mood) : base(name, age, weight, color, mood)
		{
		}

		public override void DoSound() => Console.WriteLine("Neigh! Neigh! Neigh!");

		public void Jump() => Console.WriteLine($"{Name} jumps!");
		public void Eat(string food) => Console.WriteLine($"{Name} eats {food}...");

		public override string ToString()
		{
			return $"{Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}";
		}
	}
 }
