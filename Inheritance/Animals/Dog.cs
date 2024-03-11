namespace Inheritance.Animals
{
	internal class Dog : Animal
    {
        public Dog(string name, int age, double weight, string color, MoodLevel mood, Gender gender) : base(name, age, weight, color, mood, gender)
        {
        }

        public override void DoSound() => Console.WriteLine("Bark! Bark! Bark!");

        public void Play() => Console.WriteLine($"{GetType().Name} plays!");
        public void Sleep() => Console.WriteLine($"{GetType().Name} sleeps...");

        public override string ToString()
        {
            return $"{GetType().Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}";
        }
    }
}
