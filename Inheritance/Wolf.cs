namespace Inheritance
{
	internal class Wolf : Animal
	{
		public Wolf(string name, int age, double weight, string color, MoodLevel mood) : base(name, age, weight, color, mood)
		{
		}

		public override void DoSound() => Console.WriteLine("Howl! Howl! Howl!");
	}
}
