namespace Inheritance.Animals
{
	internal class Hedgehog : Animal
	{
        public int AmountOfSpikes { get; set; }

        public Hedgehog(string name, int age, double weight, string color, Mood mood, Gender gender, int amountOfSpikes) : base(name, age, weight, color, mood, gender)
		{
			AmountOfSpikes = amountOfSpikes;
		}

		public override void DoSound() => Console.WriteLine("Grunt! Grunt! Grunt!");

		public override string Stats()
		{
			return $"{base.Stats()}\nAmount of spikes: {AmountOfSpikes}";
		}
	}
}
