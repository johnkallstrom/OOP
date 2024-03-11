namespace Inheritance.Animals.Birds
{
	internal class Swan : Bird
	{
        public bool HasMate { get; set; }

        public Swan(string name, int age, double weight, string color, MoodLevel mood, int wingspan, bool hasMate) : base(name, age, weight, color, mood, wingspan)
		{
			HasMate = hasMate;
		}
	}
}
