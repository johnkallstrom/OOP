﻿namespace Polymrphism
{
	internal class NumericcInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a numeric input in a text only field. This fired an error!";
		}
	}
}