namespace Inheritance.Animals
{
	internal class Worm : Animal
    {
        public int Length { get; set; }

        public Worm(string name, int age, double weight, string color, Mood mood, Gender gender, int length) : base(name, age, weight, color, mood, gender)
        {
            Length = length;
        }

        public override void DoSound() => Console.WriteLine("Rasp! Rasp! Rasp!");

        public void Dig() => Console.WriteLine($"{Name} starts digging!");

        public override string ToString()
        {
            return $"{GetType().Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}, {Length} cm";
        }
    }
}
