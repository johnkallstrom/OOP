namespace Inheritance
{
    internal class Wolfman : Wolf, IPerson
	{
		public Wolfman(string name, int age, double weight, string color, MoodLevel mood, int speed) : base(name, age, weight, color, mood, speed)
		{
		}

		public void Talk() => Console.WriteLine($"Hello from {Name} the {GetType().Name}.");

		public void ShapeShift() => Console.WriteLine($"{Name} turns into a wolf!");
	}
}
