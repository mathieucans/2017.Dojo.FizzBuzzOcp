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
		        .Convert(5).With("Buzz")
		        .Convert(3).With("Fizz")
		        .AndConvertWihtEchoByDefault();
		}

		public string say(int i)
		{
		    return _rules.First(r => r.match(i)).convert(i);			
		}
	}

    public class RulesBuilder
    {
        private List<ModuloRule> _moduloRules;

        public RulesBuilder()
        {
            _moduloRules = new List<ModuloRule>();
        }
        public ModuloBuilder Convert(int i)
        {
            var moduloBuilder = new ModuloBuilder(this, _moduloRules, i);            
            return moduloBuilder;
        }

        public IEnumerable<IFizzBuzzRule> AndConvertWihtEchoByDefault()
        {
            var rules = new List<IFizzBuzzRule>();
            
            var reverse= new List<ModuloRule>();
            reverse.AddRange(_moduloRules);
            reverse.Reverse();
            var concatRule = new[] {new ConcatRule(reverse)};
            rules.AddRange(concatRule);

            foreach (var moduloBuilder in _moduloRules)
            {
                rules.Add(moduloBuilder);
            }

            rules.Add(new EchoRule());
            return rules;
        }
    }

    public class ModuloBuilder
    {
        private int _modulo;
        private readonly List<ModuloRule> _moduloRules;
        private readonly RulesBuilder _rulesBuilder;
        private string _convertion;

        public ModuloBuilder(RulesBuilder rulesBuilder, List<ModuloRule> moduloRules, int i)
        {
            _rulesBuilder = rulesBuilder;
            _modulo = i;
            _moduloRules = moduloRules;
        }

        public RulesBuilder With(string convertion)
        {
            _convertion = convertion;
            _moduloRules.Add(new ModuloRule(_modulo, _convertion));
            return _rulesBuilder;
        }

    }
}