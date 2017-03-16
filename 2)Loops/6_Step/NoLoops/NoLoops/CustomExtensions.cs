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
            where T : class
            where TKey : IComparable<TKey>
        {
            var enumerable = collection as T[] ?? collection.ToArray();
            
            return enumerable
                .Select(x => Tuple.Create(x, valueFunction(x)))
                .Aggregate(
                    !enumerable.Any()
                        ? (Tuple<T, TKey>)null
                        : Tuple.Create(enumerable.First(), valueFunction(enumerable.First())),
                    (optimal, next) =>
                            optimal == null ||
                            optimal.Item2.CompareTo(next.Item2) > 0
                                ? optimal
                                : next)
                                .Item1;
        }
    }
}
