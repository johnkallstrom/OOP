using Inheritance.Enums;

namespace Inheritance
{
	internal class Dog : Animal
	{
        public MoodLevel Mood { get; set; }

        public Dog(string name, int age, double weight, string color, MoodLevel mood) : base(name, age, weight, color)
		{
			Mood = mood;
		}

		public override void DoSound() => Console.WriteLine("Bark! Bark! Bark!");

		public void Play() => Console.WriteLine($"{Name} plays!");
		public void Sleep() => Console.WriteLine($"{Name} sleeps!");

		public override string ToString()
		{
			return $"{Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}";
		}
	}
}
