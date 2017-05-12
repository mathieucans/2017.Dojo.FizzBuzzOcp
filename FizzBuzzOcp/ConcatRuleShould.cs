using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzOcp
{
    [TestClass]
    public class ConcatRuleShould
    {
        [TestMethod]
        public void match_when_all_composed_rule_are_matching()
        {
            var rules = A.CollectionOfFake<IFizzBuzzRule>(3);
            foreach (var rule in rules)
            {
                A.CallTo(() => rule.match(A<int>.Ignored)).Returns(true);
            }
            var concatRule = new ConcatRule(rules);

            Assert.IsTrue(concatRule.match(1));
        }

        [TestMethod]
        public void not_match_when_one_composed_rule_is_not_matching()
        {
            var rules = A.CollectionOfFake<IFizzBuzzRule>(3);
            A.CallTo(() => rules[1].match(A<int>.Ignored)).Returns(true);
            A.CallTo(() => rules[2].match(A<int>.Ignored)).Returns(true);
            var concatRule = new ConcatRule(rules);

            Assert.IsFalse(concatRule.match(1));
        }

        [TestMethod]
        public void convert_by_concat_all_rule_convertion()
        {
            var rules = A.CollectionOfFake<IFizzBuzzRule>(3);
            A.CallTo(() => rules[0].convert(A<int>.Ignored)).Returns("A");
            A.CallTo(() => rules[1].convert(A<int>.Ignored)).Returns("B");
            A.CallTo(() => rules[2].convert(A<int>.Ignored)).Returns("C");
            var concatRule = new ConcatRule(rules);

            var result = concatRule.convert(456);

            Assert.AreEqual("ABC", result);
        }
    }
}