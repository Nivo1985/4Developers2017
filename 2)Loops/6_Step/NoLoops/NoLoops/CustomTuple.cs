using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLoops
{
    public class CustomTuple<T, TKey>
        where T : class
        where TKey : IComparable<TKey>
    {
        private CustomTuple()
        {
            
        }

        public static CustomTuple<T, TKey> Create(T CollectionObject, TKey CollectionObjectKey)
        {
            return new CustomTuple<T, TKey>()
            {
                CollectionObject = CollectionObject,
                CollectionObjectKey = CollectionObjectKey
            };
        }

        public T CollectionObject { get; set; }
        public TKey CollectionObjectKey { get; set; }
    }
}
