namespace Inheritance.Animals
{
	internal class Hedgehog : Animal
	{
        public int AmountOfSpikes { get; set; }

        public Hedgehog(string name, int age, double weight, string color, MoodLevel mood, int amountOfSpikes) : base(name, age, weight, color, mood)
		{
			AmountOfSpikes = amountOfSpikes;
		}

		public override void DoSound() => Console.WriteLine("Grunt! Grunt! Grunt!");
	}
}
