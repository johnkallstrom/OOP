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
			set { age = value; } 
		}

        public string FirstName 
		{ 
			get { return firstName; } 
			set { firstName = value; } 
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
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
	}
}
