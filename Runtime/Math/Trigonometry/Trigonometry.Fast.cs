using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public static partial class Trigonometry
		{
			private const int _INDEX_MASK = ~(-1 << 12);
			private const float _INDEX_FACTOR = (_CACHE_SIZE / Constants.TAU);
			private const int _CACHE_SIZE = (_INDEX_MASK + 1);

			private static readonly float[] SinCache, CosCache, TanCache, AsinCache, AcosCache, AtanCache;

			static Trigonometry()
			{
				SinCache = new float[_CACHE_SIZE];
				CosCache = new float[_CACHE_SIZE];
				TanCache = new float[_CACHE_SIZE];

				AsinCache = new float[_CACHE_SIZE];
				AcosCache = new float[_CACHE_SIZE];
				AtanCache = new float[_CACHE_SIZE];

				int __index;
				for (__index = 0; __index < _CACHE_SIZE; __index++)
				{
					float __value = ((__index + 0.5f) / _CACHE_SIZE * Constants.TAU);
					SinCache[__index] = Mathf.Sin(__value);
					CosCache[__index] = Mathf.Cos(__value);
					TanCache[__index] = Mathf.Tan(__value);

					AsinCache[__index] = Mathf.Asin(__value);
					AcosCache[__index] = Mathf.Acos(__value);
					AtanCache[__index] = Mathf.Atan(__value);
				}

				const float __FACTOR = (_CACHE_SIZE / 360f);
				for (__index = 0; __index < 360; __index += 90)
				{
					int __element = (int) (__index * __FACTOR) & _INDEX_MASK;

					float __angleRadian = (__index * Constants.DEG_TO_RAD);

					SinCache[__element] = Mathf.Sin(__angleRadian);
					CosCache[__element] = Mathf.Cos(__angleRadian);
					TanCache[__index] = Mathf.Tan(__angleRadian);

					//needed??
					AsinCache[__element] = Mathf.Asin(__angleRadian);
					AcosCache[__element] = Mathf.Acos(__angleRadian);
					AtanCache[__element] = Mathf.Atan(__angleRadian);
				}
			}

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastSin(in this float value)
				=> SinCache[(int) (value * _INDEX_FACTOR) & _INDEX_MASK];

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastCos(in this float value)
				=> CosCache[(int) (value * _INDEX_FACTOR) & _INDEX_MASK];

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastTan(in this float value)
				=> TanCache[(int) (value * _INDEX_FACTOR) & _INDEX_MASK];

			//TODO: Maybe add clamps to Asin/Acos, so it doesn't excede -1 and 1

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastAsin(in this float value)
				=> AsinCache[(int) (value * _INDEX_FACTOR) & _INDEX_MASK];

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastAcos(in this float value)
				=> AcosCache[(int) (value * _INDEX_FACTOR) & _INDEX_MASK];

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastAtan(in this float value)
				=> AtanCache[(int) (value * _INDEX_FACTOR) & _INDEX_MASK];

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FastSqrt(this int value)
			{
				if (value == 0) return 0; // Avoid zero divide

				int n = (value / 2) + 1; // Initial estimate, never low
				int n1 = (n + (value / n)) / 2;

				while (n1 < n)
				{
					n = n1;
					n1 = (n + (value / n)) / 2;
				}

				return n;
			}
			
			[StructLayout(LayoutKind.Explicit)]
			private struct IntFloat
			{
				[UsedImplicitly]
				[FieldOffset(0)]
				public int Int;
				
				[UsedImplicitly]
				[FieldOffset(0)]
				public float Float;
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static unsafe float FastSqrt(this float value)
			{
				IntFloat __union;
				
				__union.Float = 0;

				__union.Int = 0x2035AD0C + (*(int*)(&value) >> 1);
				
				return value / __union.Float + __union.Float * 0.25f;
			}
		}
	}
}