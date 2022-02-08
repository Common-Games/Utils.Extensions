using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace CGTK.Utils.Extensions.Collections
{
    [PublicAPI]
    public static class DictionaryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, in TKey key) 
            where TValue : new()
        {
            if (dictionary.TryGetValue(key, value: out TValue __value)) return __value;
            
            __value = new TValue();
            dictionary.Add(key: key, value: __value);

            return __value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean GetIfExists<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, in TKey key, out TValue value)
        {
            if (!dictionary.ContainsKey(key))
            {
                value = dictionary[key: key];
                return true;
            }

            value = default;
            return false;
        }
        
        public static void AddIfNew<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, in TKey key, in TValue value)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key: key, value: value);
            }
        }
    }
}
