using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
	using F32 = Single;
	using F64 = Double;

	using I8  = SByte;
	using I16 = Int16;
	using I32 = Int32;
	using I64 = Int64;

	using U8  = Byte;
	using U16 = UInt16;
	using U32 = UInt32;
	using U64 = UInt64;

	namespace Math
	{
		[PublicAPI]
		public static partial class Interpolation
		{
			[MethodImpl(INLINE)]
			public static Color Lerp(in this Color from, in Color to, in F32 t)
				=> Color.Lerp(a: from, b: to, t: t);
			
			[MethodImpl(INLINE)]
			public static Color LerpUnclamped(in this Color from, in Color to, in F32 t)
				=> Color.LerpUnclamped(a: from, b: to, t: t);
			
			[MethodImpl(INLINE)]
			public static Vector3 LerpInverse(in this Color value, in Color from, in Color to)
			{
				F32 r = Mathf.InverseLerp(a: from.r, b: to.r, value: value.r);
				F32 g = Mathf.InverseLerp(a: from.g, b: to.g, value: value.g);
				F32 b = Mathf.InverseLerp(a: from.b, b: to.b, value: value.b);

				return new Vector3(r, g, b);
			}
		}
	}
}