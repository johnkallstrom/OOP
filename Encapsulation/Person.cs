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
				else
				{
					throw new ArgumentException($"{nameof(Age)} must be greater than 0");
				}
			} 
		}

        public string FirstName 
		{ 
			get { return firstName; } 
			set 
			{ 
				if (!string.IsNullOrWhiteSpace(value) && value.IsBetween(2, 10))
				{
					firstName = value;
				}
				else
				{
					throw new ArgumentException($"{nameof(FirstName)} is required and cannot be less than 2 or greater than 10 characters");
				}
			} 
		}

		public string LastName
		{
			get { return lastName; }
			set 
			{ 
				if (!string.IsNullOrWhiteSpace(value) && value.IsBetween(3, 15))
				{
					lastName = value;
				}
				else
				{
					throw new ArgumentException($"{nameof(LastName)} is required and cannot be less than 3 or greater than 15 characters");
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
