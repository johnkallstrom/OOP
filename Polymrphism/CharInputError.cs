namespace Polymrphism
{
	internal class CharInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a character input in a numeric only field. This fired an error!";
		}
	}
}
