using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
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
		public static partial class Interpolation
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 Lerp(in this Vector2 from, in Vector2 to, in F32 t)
				=> Vector2.Lerp(a: from, b: to, t: t);
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 LerpUnclamped(in this Vector2 from, in Vector2 to, in F32 t)
				=> Vector2.LerpUnclamped(a: from, b: to, t: t);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector2 MoveTowards(in this Vector2 current, in Vector2 target, in F32 maxDistanceDelta)
				=> Vector2.MoveTowards(current: current, target: target, maxDistanceDelta: maxDistanceDelta);
		}
	}
}