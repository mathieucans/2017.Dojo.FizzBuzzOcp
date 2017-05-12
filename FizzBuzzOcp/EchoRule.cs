namespace FizzBuzzOcp
{
    public class EchoRule : IFizzBuzzRule	
    {
        public bool match(int i)
        {
            return true;
        }

        public string convert(int i)
        {
            return i.ToString();
        }
    }
}