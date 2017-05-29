using System.Collections.Generic;
using System.Linq;

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

            foreach (var moduloBuilder in _moduloRules)
            {
                rules.Add(moduloBuilder);
            }

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

    public static class CombiniaisonExtension
    {

        public static IEnumerable<IEnumerable<T>> AllCombinaison<T>(this IEnumerable<T> elements)
        {
            var list = new List<IEnumerable<T>>();
            for (int i = elements.Count() ; i >= 2; i--)
            {
                list.AddRange(elements.AllCombinaison(i));
            }
            return list;
        }
        public static IEnumerable<IEnumerable<T>> AllCombinaison<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new []{ new T[0] } : 
                elements.SelectMany( (e, i) => elements.Skip( i + 1).AllCombinaison(k -1).Select( c => (new [] {e}).Concat(c)))
            ;
        }
    }
}