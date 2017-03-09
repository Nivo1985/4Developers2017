using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLoops
{
    public static class CustomExtensions
    {
        public static T Optional<T, TKey>(this IEnumerable<T> collection, Func<T, TKey> valueFunction)
            where T:class 
            where TKey: IComparable<TKey> =>
            collection.Aggregate((T)null, (optimal, next) =>
                optimal == null ||
                valueFunction(optimal).CompareTo(valueFunction(next)) > 0  ?
                optimal : next);
    }
}
