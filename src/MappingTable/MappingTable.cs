using System;

namespace System.Collections.Generic
{
    public class MappingTable<TKey, TValue>
    {
        public Dictionary<TKey, TValue> Mapping { get; set; } = new Dictionary<TKey, TValue>();
        public TValue Default { get; set; }

        public TValue this[TKey index]
        {
            get
            {
                if (Mapping.TryGetValue(index, out TValue value))
                {
                    return value;
                }

                return Default;
            }
            set
            {
                Mapping[index] = value;
            }
        }
    }
}
