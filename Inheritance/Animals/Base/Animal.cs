namespace Inheritance.Animals.Base
{
	internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public Mood Mood { get; set; }
        public Gender Gender { get; set; }

        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Type: {GetType().Name}\nName: {Name}\nGender: {Gender}\nAge: {Age} years old\nWeight: {Weight} kg\nColor: {Color}\nMood: {Mood}";
        }

        protected Animal(string name, int age, double weight, string color, Mood mood, Gender gender)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            Mood = mood;
            Gender = gender;
        }
    }
}
