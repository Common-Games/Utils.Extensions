using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Mathematics;
using Random = System.Random;

namespace CGTK.Utilities.Extensions.Collection
{
    [PublicAPI]
    public static class IListExtensions
    {
        private static readonly Random DefaultRNG = new Random();
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T RandomElement<T>(this IList<T> list, in Random RNG = null)
            => (list.Count == 0) ? default : list.ElementAt(index: (RNG ?? DefaultRNG).Next(maxValue: list.Count));
        
        public static float2 ToFloat2(this IList<float> value)
        {
            return new float2()
            {
                x = value[0],
                y = value[1],
            };
        }
        public static float3 ToFloat3(this IList<float> value)
        {
            return new float3()
            {
                x = value[0],
                y = value[1],
                z = value[2],
            };
        }
        public static float4 ToFloat4(this IList<float> value)
        {
            return new float4()
            {
                x = value[0],
                y = value[1],
                z = value[2],
                w = value[3],
            };
        }
        
        public static int2 ToInt2(this IList<int> value)
        {
            return new int2()
            {
                x = value[0],
                y = value[1],
            };
        }
        public static int3 ToInt3(this IList<int> value)
        {
            return new int3()
            {
                x = value[0],
                y = value[1],
                z = value[2],
            };
        }
        public static int4 ToInt4(this IList<int> value)
        {
            return new int4()
            {
                x = value[0],
                y = value[1],
                z = value[2],
                w = value[3],
            };
        }
        
        public static quaternion ToQuaternion(this IList<float> value)
        {
            return new quaternion()
            {
                value = value.ToFloat4()
            };
        }
    }
}
