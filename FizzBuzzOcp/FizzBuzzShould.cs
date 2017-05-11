﻿using System;
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
