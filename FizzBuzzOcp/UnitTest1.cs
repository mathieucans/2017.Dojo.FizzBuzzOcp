using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOcp
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void say_1_when_1()
		{
			var say = new Say();
			Assert.AreEqual("1", say.say(1));
		}

		[TestMethod]
		public void say_2_when_2()
		{
			var say = new Say();
			Assert.AreEqual("2", say.say(2));
		}
	}

	public class Say
	{
		public string say(int i)
		{
			return i.ToString();
		}
	}
}
