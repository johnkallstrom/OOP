namespace Encapsulation
{
	internal class Person
	{
		private int age;
		private string firstName;
		private string lastName;
		private int height;
		private int weight;

        public int Age 
		{ 
			get { return age; } 
			set 
			{ 
				if (value > 0)
				{
					age = value;
				}
			} 
		}

        public string FirstName 
		{ 
			get { return firstName; } 
			set 
			{ 
				if (value.Length >= 2 && value.Length <= 10)
				{
					firstName = value;
				}
			} 
		}

		public string LastName
		{
			get { return lastName; }
			set 
			{ 
				if (value.Length >= 3 && value.Length <= 15)
				{
					lastName = value;
				}
			}
		}

		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		public override string ToString()
		{
			return $"Name: {firstName} {lastName}\nAge: {age}\nHeight: {height}\nWeight: {Weight}";
		}
	}
}
