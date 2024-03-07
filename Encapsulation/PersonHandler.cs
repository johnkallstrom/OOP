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

		public void UpdatePerson(Person personToUpdate, int age, string firstName, string lastName, double height, double weight)
		{
			personToUpdate.Age = age;
			personToUpdate.FirstName = firstName;
			personToUpdate.LastName = lastName;
			personToUpdate.Height = height;
			personToUpdate.Weight = weight;
		}

		// Todo: Is not working
		public void DeletePerson(Person personToDelete)
		{
			personToDelete = null;
		}
	}
}
