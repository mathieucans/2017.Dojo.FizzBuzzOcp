using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOcp
{
    [TestClass]
	public class FizzBuzzShould
	{
		[TestMethod]
		public void say_1_when_1()
		{
			var say = new FizzBuzz();
			Assert.AreEqual("1", say.say(1));
		}

		[TestMethod]
		public void say_2_when_2()
		{
			var say = new FizzBuzz();
			Assert.AreEqual("2", say.say(2));
		}

		[TestMethod]
		public void say_Fizz_when_modulo_3()
		{
			var say = new FizzBuzz();
			Assert.AreEqual("Fizz", say.say(3));
			Assert.AreEqual("Fizz", say.say(6));
			Assert.AreEqual("Fizz", say.say(12));
		}

		[TestMethod]
		public void say_Fizz_when_modulo_5()
		{
			var say = new FizzBuzz();
			Assert.AreEqual("Buzz", say.say(5));
			Assert.AreEqual("Buzz", say.say(10));
			Assert.AreEqual("Buzz", say.say(20));
		}

        [TestMethod]
		public void say_FizzBuzz_when_modulo_5_and_3()
		{
			var say = new FizzBuzz();
			Assert.AreEqual("FizzBuzz", say.say(15));
			Assert.AreEqual("FizzBuzz", say.say(30));
			Assert.AreEqual("FizzBuzz", say.say(45));
		}


	}
}
