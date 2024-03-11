namespace Inheritance.Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, int age, double weight, string color, MoodLevel mood) : base(name, age, weight, color, mood)
        {
        }

        public override void DoSound() => Console.WriteLine("Bark! Bark! Bark!");

        public void Play() => Console.WriteLine($"{Name} plays!");
        public void Sleep() => Console.WriteLine($"{Name} sleeps...");

        public override string ToString()
        {
            return $"{GetType().Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}";
        }
    }
}
