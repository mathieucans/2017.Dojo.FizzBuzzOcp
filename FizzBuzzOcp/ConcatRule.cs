using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzOcp
{
    public class ConcatRule : IFizzBuzzRule
    {
        private readonly IEnumerable<IFizzBuzzRule> _rules;

        public ConcatRule(IEnumerable<IFizzBuzzRule> rules)
        {
            _rules = rules;
        }

        public bool match(int i)
        {
            return _rules.Aggregate(true, (a,b) => a && b.match(i));
        }

        public string convert(int i)
        {
            return _rules.Aggregate("", (a, b) => string.Concat(a, b.convert(i)));
        }
    }
}