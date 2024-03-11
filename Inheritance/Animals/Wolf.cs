namespace Inheritance.Animals
{
	internal class Wolf : Animal
    {
        public int Speed { get; set; }

        public Wolf(string name, int age, double weight, string color, MoodLevel mood, int speed) : base(name, age, weight, color, mood)
        {
            Speed = speed;
        }

        public override void DoSound() => Console.WriteLine("Howl! Howl! Howl!");

        public override string ToString()
        {
            return $"{GetType().Name} - {Age} years old, {Weight} kg, {Color} color, {Mood}, Runs at {Speed} km/h";
        }
    }
}
