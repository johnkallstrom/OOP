namespace Inheritance.Animals
{
    internal class Pelican : Bird
    {
        public int BeakLength { get; set; }

        public Pelican(string name, int age, double weight, string color, Mood mood, Gender gender, int wingspan, int beakLength) : base(name, age, weight, color, mood, gender, wingspan)
        {
            BeakLength = beakLength;
        }

        public void Dive() => Console.WriteLine($"{GetType().Name} dives for fish!");

		public override string Stats()
		{
            return $"{base.Stats()}\nBeak length: {BeakLength} cm\nWingspan: {Wingspan} cm";
		}
	}
}
