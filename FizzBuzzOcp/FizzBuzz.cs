using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzOcp
{
    public class FizzBuzz
	{
		private IEnumerable<IFizzBuzzRule> _rules;
		
		public FizzBuzz()
		{
		    _rules = new RulesBuilder()
		        .Convert(7).With("Bang")
		        .Convert(5).With("Buzz")
		        .Convert(3).With("Fizz")
		        .AndConvertWihtEchoByDefault();
		}

		public string say(int i)
		{
		    return _rules.First(r => r.match(i)).convert(i);			
		}
	}
}