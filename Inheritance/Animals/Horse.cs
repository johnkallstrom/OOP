namespace Inheritance.Animals
{
	internal class Horse : Animal
    {
        public double Height { get; set; }

        public Horse(string name, int age, double weight, string color, Mood mood, Gender gender, double height) : base(name, age, weight, color, mood, gender)
        {
            Height = height;
        }

        public override void DoSound() => Console.WriteLine("Neigh! Neigh! Neigh!");

        public void Jump() => Console.WriteLine($"{Name} jumps!");
        public void Eat(string food) => Console.WriteLine($"{Name} eats {food}...");

        public override string ToString()
        {
            return $"{GetType().Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}";
        }

		public override string Stats()
		{
            return $"{base.Stats()}\nHeight: {Height} meters";
		}
	}
}
