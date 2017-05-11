using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOcp
{
	[TestClass]
	public class FizzRuleShould
	{
		private FizzRule _rule = new FizzRule();

		[TestMethod]
		public void match_when_modulo_3()
		{
			Assert.IsTrue(_rule.match(3));
			Assert.IsTrue(_rule.match(9));
			Assert.IsTrue(_rule.match(12));
		}

		[TestMethod]
		public void not_match_when_not_modulo_3()
		{
			
			Assert.IsFalse(_rule.match(1));
			Assert.IsFalse(_rule.match(2));
			Assert.IsFalse(_rule.match(64));
		}

		[TestMethod]
		public void convert_to_Fizz()
		{
			Assert.AreEqual("Fizz", _rule.convert(1235));
		}
	}
}