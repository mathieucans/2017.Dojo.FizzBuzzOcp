using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzOcp
{
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