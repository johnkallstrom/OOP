namespace Inheritance
{
	internal class Wolf : Animal
	{
		public Wolf(string name, int age, double weight, string color) : base(name, age, weight, color)
		{
		}

		public override void DoSound() => Console.WriteLine("Howl! Howl! Howl!");
	}
}
