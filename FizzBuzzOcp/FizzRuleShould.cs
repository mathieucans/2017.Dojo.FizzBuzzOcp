using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOcp
{
	[TestClass]
	public class BuzzRuleShould
	{
		ModuloRule _rule = new ModuloRule(5, "Buzz");

		[TestMethod]
		public void convert_to_Buzz()
		{
			Assert.AreEqual("Buzz", _rule.convert(1235));
		}
	}

	[TestClass]
	public class FizzRuleShould
	{
		ModuloRule _rule = new ModuloRule(5, "Fizz");

		[TestMethod]
		public void convert_to_Fizz()
		{
			Assert.AreEqual("Fizz", _rule.convert(1235));
		}
	}
}