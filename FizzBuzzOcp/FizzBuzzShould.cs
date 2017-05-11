using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOcp
{
	[TestClass]
	public class FizzBuzzShould
	{
		[TestMethod]
		public void say_1_when_1()
		{
			var say = new FizzBuz();
			Assert.AreEqual("1", say.say(1));
		}

		[TestMethod]
		public void say_2_when_2()
		{
			var say = new FizzBuz();
			Assert.AreEqual("2", say.say(2));
		}

		[TestMethod]
		public void say_Fizz_when_modulo_3()
		{
			var say = new FizzBuz();
			Assert.AreEqual("Fizz", say.say(3));
		}
	}
}
