namespace Inheritance
{
    internal class Wolfman : Wolf, IPerson
	{
        public string WeaponOfChoice { get; set; }

        public Wolfman(string name, int age, double weight, string color, MoodLevel mood, Gender gender, int speed, string weaponOfChoice) : base(name, age, weight, color, mood, gender, speed)
		{
			WeaponOfChoice = weaponOfChoice;
		}

		public void Talk() => Console.WriteLine($"Hello from {Name} the {GetType().Name}.");

		public void ShapeShift() => Console.WriteLine($"{Name} turns into a wolf!");

		public override string Stats()
		{
			return $"{base.Stats()}\nWeapon of choice: {WeaponOfChoice}";
		}
	}
}
