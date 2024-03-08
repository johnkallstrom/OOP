namespace Encapsulation
{
	internal class PersonHandler
	{
		public void SetAge(Person person, int value)
		{
			person.Age = value;
		}

		public Person CreatePerson(int age, string firstName, string lastName, double height, double weight)
		{
			return new Person
			{
				Age = age,
				FirstName = firstName,
				LastName = lastName,
				Height = height,
				Weight = weight
			};
		}

		public void UpdatePerson(Person person, int age, string firstName, string lastName, double height, double weight)
		{
			person.Age = age;
			person.FirstName = firstName;
			person.LastName = lastName;
			person.Height = height;
			person.Weight = weight;
		}

		public void DeletePerson(Person person)
		{
			person = null;
		}
	}
}
