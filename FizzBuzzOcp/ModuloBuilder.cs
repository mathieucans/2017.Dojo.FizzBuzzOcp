    using System.Collections.Generic;

namespace FizzBuzzOcp
{
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