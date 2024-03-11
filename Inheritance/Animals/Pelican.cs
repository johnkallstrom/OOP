namespace Inheritance.Animals
{
    internal class Pelican : Bird
    {
        public Pelican(string name, int age, double weight, string color, MoodLevel mood, int wingspan) : base(name, age, weight, color, mood, wingspan)
        {
        }

        public void Dive() => Console.WriteLine($"{GetType().Name} dives for fish!");
    }
}
