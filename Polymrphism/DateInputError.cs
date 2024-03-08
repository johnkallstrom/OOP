namespace Polymrphism
{
	internal class DateInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a date input in a text only field. This fired an error!";
		}
	}
}
