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
        public void say_Bang_when_modulo_7()
        {
            var say = new FizzBuzz();
            Assert.AreEqual("Bang", say.say(7));
            Assert.AreEqual("Bang", say.say(14));
            Assert.AreEqual("Bang", say.say(28));
        }


        [TestMethod]
		public void say_FizzBuzz_when_modulo_5_and_3()
		{
			var say = new FizzBuzz();
			Assert.AreEqual("FizzBuzz", say.say(15), "15");
			Assert.AreEqual("FizzBuzz", say.say(30) , "30");
			Assert.AreEqual("FizzBuzz", say.say(45) , "45");
		}

        [TestMethod]
        public void say_FizzBang_when_modulo_7_and_3()
        {
            var say = new FizzBuzz();
            Assert.AreEqual("FizzBang", say.say(21), "21");
            Assert.AreEqual("FizzBang", say.say(42), "42");
            Assert.AreEqual("FizzBang", say.say(63), "63");
        }

        [TestMethod]
        public void say_FizzBuzzBang_when_modulo_7_5_and_3()
        {
            var say = new FizzBuzz();
            Assert.AreEqual("FizzBuzzBang", say.say(105), "105");
        }


    }
}
