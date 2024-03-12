namespace Inheritance.Animals
{
    internal class Swan : Bird
    {
        public bool InRelationship { get; set; }

        public Swan(string name, int age, double weight, string color, Mood mood, Gender gender, int wingspan, bool inRelationship) : base(name, age, weight, color, mood, gender, wingspan)
        {
            InRelationship = inRelationship;
        }

		public override string Stats()
		{
            string result = InRelationship is true ? "Yes" : "No";
            return $"{base.Stats()}\nIn relationship: {result}";
		}
	}
}
