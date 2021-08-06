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
		[PublicAPI]
		public static partial class VectorExtensions
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32[] ToArray(in this float4 self)
				=> new F32[4]
				{
					self.x,
					self.y,
					self.z,
					self.w,
				};

		}
	}
}