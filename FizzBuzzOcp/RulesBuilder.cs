using System.Collections.Generic;

namespace FizzBuzzOcp
{
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
            
            var concatRule = BuildConcatRules();
            rules.AddRange(concatRule);

            rules.Add(new EchoRule());
            return rules;
        }

        private List<ConcatRule> BuildConcatRules()
        {
            var reverse = new List<ModuloRule>();
            reverse.AddRange(_moduloRules);
            reverse.Reverse();

            var concatRule = new List<ConcatRule>();

            var allCombinaison = reverse.AllCombinaison();
            foreach (var combinaison in allCombinaison)
            {
                concatRule.Add(new ConcatRule(combinaison));
            }

            return concatRule;
        }
    }
}