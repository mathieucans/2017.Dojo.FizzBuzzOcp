namespace FizzBuzzOcp
{
	internal class BuzzRule : IFizzBuzzRule
	{
		public bool match(int i)
		{
			return (i%5) == 0;
		}

		public string convert(int i)
		{
			return "Buzz";
		}
	}
}