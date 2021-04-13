using System.Runtime.CompilerServices;

using JetBrains.Annotations;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public static partial class Trigonometry
		{
			private const int   _INDEX_MASK  = ~(-1 << 12);
			private const float _INDEX_FACTOR = (_CACHE_SIZE / Constants.TAU);
			private const int   _CACHE_SIZE   = (_INDEX_MASK + 1);
			
			private static readonly float[] SinCache, CosCache, AsinCache, AcosCache;

			static Trigonometry()
			{
				SinCache  = new float[_CACHE_SIZE];
				CosCache  = new float[_CACHE_SIZE];
				AsinCache = new float[_CACHE_SIZE];
				AcosCache = new float[_CACHE_SIZE];
				
				int __index;
				for (__index = 0; __index < _CACHE_SIZE; __index++)
				{
					float __value = ((__index + 0.5f) / _CACHE_SIZE * Constants.TAU);
					SinCache[__index]  = (float)System.Math.Sin( __value);
					CosCache[__index]  = (float)System.Math.Cos( __value);
					AsinCache[__index] = (float)System.Math.Asin(__value);
					AcosCache[__index] = (float)System.Math.Acos(__value);
				}

				const float __FACTOR = (_CACHE_SIZE / 360f);
				for (__index = 0; __index < 360; __index += 90)
				{
					int __element = (int)(__index * __FACTOR) & _INDEX_MASK;

					float __angleRadian = (__index * Constants.DEG_TO_RAD);
					
					SinCache[__element] = (float)System.Math.Sin( __angleRadian);
					CosCache[__element] = (float)System.Math.Cos( __angleRadian);
					SinCache[__element] = (float)System.Math.Asin(__angleRadian);
					CosCache[__element] = (float)System.Math.Acos(__angleRadian);
				}
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastSin(this float value)
				=> SinCache[(int)(value * _INDEX_FACTOR) & _INDEX_MASK];
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastCos(this float value)
				=> CosCache[(int)(value * _INDEX_FACTOR) & _INDEX_MASK];
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastAsin(this float value)
				=> AsinCache[(int)(value * _INDEX_FACTOR) & _INDEX_MASK];
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float FastAcos(this float value)
				=> AcosCache[(int)(value * _INDEX_FACTOR) & _INDEX_MASK];
		}
	}
}