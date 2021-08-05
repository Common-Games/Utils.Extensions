using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;

namespace CGTK.Utilities.Extensions
{
	using F32 = Single;
	using F64 = Double;

	using I32 = Int32;
	using I64 = Int64;

	namespace Math
	{
		public static partial class VectorExtensions
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32[] ToArray(in this float3 self)
			{
				F32[] __array = new F32[3];

				__array[0] = self[0];
				__array[1] = self[1];
				__array[2] = self[2];

				return __array;
			}

		}
	}
}