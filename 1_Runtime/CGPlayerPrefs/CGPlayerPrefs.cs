using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
    using static PackageConstants;
    
    using F32 = Single;

    using I32 = Int32;
    using I64 = Int64;
    
    using U8  = Byte;
    using U16 = UInt16;
    using U32 = UInt32;

    [PublicAPI]
    public static partial class CGPlayerPrefs
    {
        [MethodImpl(INLINE)]
        public static F32[] Load(this String key, in U16 arrayLength, params F32[] defaultValue)
            => Load(key, arrayLength, PlayerPrefs.GetFloat, defaultValue);

        [MethodImpl(INLINE)]
        public static I32[] Load(this String key, in U16 arrayLength, params I32[] defaultValue)
            => Load(key, arrayLength, PlayerPrefs.GetInt, defaultValue);
        
        [MethodImpl(INLINE)]
        public static String[] Load(this String key, in U16 arrayLength, params String[] defaultValue)
            => Load(key, arrayLength, PlayerPrefs.GetString, defaultValue);

        [MethodImpl(INLINE)]
        private static T[] Load<T>(this String key, in U16 arrayLength, in Func<String, T, T> getFn, params T[] defaultValue)
        {
            T[] __result = new T[arrayLength];

            for (U16 __index = 0; __index < arrayLength; __index++)
            {
                String __indexKey = key + '[' + __index + ']';

                if (!PlayerPrefs.HasKey(key: __indexKey))
                {
                    Debug.LogWarning(message: "Couldn't get result, returning defaultValue");

                    return defaultValue;
                }

                __result[__index] = getFn(arg1: key + '[' + __index + ']', default);
            }

            return __result;
        }
        
        
        [MethodImpl(INLINE)]
        public static void Save(this String key, in F32[] value)
        {
            for (U16 __index = 0; __index < value.Length; __index++)
            {
                PlayerPrefs.SetFloat(key: key + '[' + __index + ']', value: value[__index]);
            }
        }
        
        [MethodImpl(INLINE)]
        public static void Save(this String key, in I32[] value)
        {
            for (U16 __index = 0; __index < value.Length; __index++)
            {
                PlayerPrefs.SetInt(key: key + '[' + __index + ']', value: value[__index]);
            }
        }
        
        [MethodImpl(INLINE)]
        public static void Save(this String key, in String[] value)
        {
            for (U16 __index = 0; __index < value.Length; __index++)
            {
                PlayerPrefs.SetString(key: key + '[' + __index + ']', value: value[__index]);
            }
        }
    }
}