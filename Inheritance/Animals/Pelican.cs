namespace Inheritance.Animals
{
    internal class Pelican : Bird
    {
        public Pelican(string name, int age, double weight, string color, MoodLevel mood, Gender gender, int wingspan) : base(name, age, weight, color, mood, gender, wingspan)
        {
        }

        public void Dive() => Console.WriteLine($"{GetType().Name} dives for fish!");

		public override string Stats()
		{
            return $"{base.Stats()}\nWingspan: {Wingspan} cm";
		}
	}
}
