namespace Inheritance.Animals
{
	internal class Bird : Animal
	{
        public int Wingspan { get; set; }

        public Bird(string name, int age, double weight, string color, Mood mood, Gender gender, int wingspan) : base(name, age, weight, color, mood, gender)
		{
			Wingspan = wingspan;
		}

		public override void DoSound() => Console.WriteLine("Chirp! Chirp! Chirp!");

		public void Sing() => Console.WriteLine($"{GetType().Name} starts singing!");
		public void Fly() => Console.WriteLine($"{GetType().Name} starts flying!");
	}
}
