namespace FizzBuzzOcp
{


    public class ModuloRule : IFizzBuzzRule
    {
        private readonly string _convert;
        private readonly int _modulo;

        public ModuloRule(int modulo, string convert)
        {
            _modulo = modulo;
            _convert = convert;
        }

        public bool match(int i)
        {
            return i%_modulo == 0;
        }

        public string convert(int i)
        {
            return i % _modulo == 0 ? _convert : "";
        }
    }
}