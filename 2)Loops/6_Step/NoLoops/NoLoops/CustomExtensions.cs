using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLoops
{
    public static class CustomExtensions
    {
        public static T Optimal<T, TKey>(this IEnumerable<T> collection, Func<T, TKey> valueFunction)
            where T : class
            where TKey : IComparable<TKey>
        {
            var enumerable = collection as T[] ?? collection.ToArray();
            
            return enumerable
                .Select(x => CustomTuple<T, TKey>.Create(x, valueFunction(x)))
                .Aggregate(
                    !enumerable.Any()
                        ? (CustomTuple<T, TKey>)null
                        : CustomTuple<T, TKey>.Create(enumerable.First(), valueFunction(enumerable.First())),
                    (optimal, next) =>
                            optimal == null ||
                            optimal.CollectionObjectKey.CompareTo(next.CollectionObjectKey) > 0
                                ? optimal
                                : next)
                                .CollectionObject;
        }
    }
}
