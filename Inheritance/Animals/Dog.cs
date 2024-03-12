namespace Inheritance.Animals
{
	internal class Dog : Animal
    {
        public bool IsMixedBreed { get; set; }

        public Dog(string name, int age, double weight, string color, Mood mood, Gender gender, bool isMixedBreed) : base(name, age, weight, color, mood, gender)
        {
            IsMixedBreed = isMixedBreed;
        }

        public override void DoSound() => Console.WriteLine("Bark! Bark! Bark!");

        public void Play() => Console.WriteLine($"{GetType().Name} plays!");
        public void Sleep() => Console.WriteLine($"{GetType().Name} sleeps...");
        public string Toy() => "Bone";

        public override string ToString()
        {
            return $"{GetType().Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}";
        }

		public override string Stats()
		{
            string result = IsMixedBreed is true ? "Yes" : "No";
            return $"{base.Stats()}\nMixed-breed: {result}";
		}
	}
}
