namespace FizzBuzzOcp
{
    public interface  IFizzBuzzRule
    {
        bool match(int i);
        string convert(int i);
    }
}