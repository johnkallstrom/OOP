namespace Inheritance.Animals
{
    internal class Flamingo : Bird
    {
        public string Species { get; set; }

        public Flamingo(string name, int age, double weight, string color, Mood mood, Gender gender, int wingspan, string species) : base(name, age, weight, color, mood, gender, wingspan)
        {
            Species = species;
        }

        public void Dance() => Console.WriteLine($"{GetType().Name} starts dancing!");

		public override string Stats()
		{
            return $"{base.Stats()}\nWingspan: {Wingspan} cm";
		}
	}
}
