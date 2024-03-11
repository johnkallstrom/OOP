﻿namespace Inheritance.Animals
{
	internal class Bird : Animal
	{
        public int Wingspan { get; set; }

        public Bird(string name, int age, double weight, string color, MoodLevel mood, int wingspan) : base(name, age, weight, color, mood)
		{
			Wingspan = wingspan;
		}

		public override void DoSound() => Console.WriteLine("Chirp! Chirp! Chirp!");

		public void Sing() => Console.WriteLine($"{GetType().Name} starts singing!");
		public void Fly() => Console.WriteLine($"{GetType().Name} starts flying!");
	}
}