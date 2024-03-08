namespace Polymrphism
{
	internal class DoubleInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a double input in a whole numbers only field. This fired an error!";
		}
	}
}
