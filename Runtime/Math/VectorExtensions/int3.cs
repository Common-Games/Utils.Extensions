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
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static I32[] ToArray(in this int3 self)
				=> new I32[3]
				{
					self.x,
					self.y,
					self.z,
				};
		}
	}
}