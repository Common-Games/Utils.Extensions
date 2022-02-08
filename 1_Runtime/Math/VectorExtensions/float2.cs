using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
	using F32 = Single;
	using F64 = Double;

	using I32 = Int32;
	using I64 = Int64;

	namespace Math
	{
		[PublicAPI]
		public static partial class VectorExtensions
		{
			[MethodImpl(INLINE)]
			public static F32[] ToArray(in this float2 self)
				=> new F32[2]
				{
					self.x,
					self.y,
				};

		}
	}
}