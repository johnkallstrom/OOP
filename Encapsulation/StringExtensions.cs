namespace Encapsulation
{
	internal static class StringExtensions
	{
		public static bool IsBetween(this string value, int min, int max)
		{
			return value.Length >= min && value.Length <= max;
		}
	}
}
