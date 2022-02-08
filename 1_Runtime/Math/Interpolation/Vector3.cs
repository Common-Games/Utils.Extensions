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
		public static partial class Interpolation
		{
			[MethodImpl(INLINE)]
			public static Vector3 Lerp(in this Vector3 from, in Vector3 to, in F32 t)
				=> Vector3.Lerp(a: from, b: to, t: t);

			[MethodImpl(INLINE)]
			public static Vector3 LerpUnclamped(in this Vector3 from, in Vector3 to, in F32 t)
				=> Vector3.LerpUnclamped(a: from, b: to, t: t);
			
			
			[MethodImpl(INLINE)]
			public static Vector3 Slerp(in this Vector3 from, in Vector3 to, in F32 t)
				=> Vector3.Slerp(a: from, b: to, t: t);
			[MethodImpl(INLINE)]
			public static Vector3 SlerpUnclamped(in this Vector3 from, in Vector3 to, in F32 t)
				=> Vector3.SlerpUnclamped(a: from, b: to, t: t);
			
			
			[MethodImpl(INLINE)]
			public static Vector3 MoveTowards(in this Vector3 current, in Vector3 target, in F32 maxDistanceDelta)
				=> Vector3.MoveTowards(current: current, target: target, maxDistanceDelta: maxDistanceDelta);
			
			[MethodImpl(INLINE)]
			public static Vector3 RotateTowards(in this Vector3 current, in Vector3 target, in F32 maxRadiansDelta, in F32 maxMagnitudeDelta)
				=> Vector3.RotateTowards(current: current, target: target, maxRadiansDelta: maxRadiansDelta, maxMagnitudeDelta: maxMagnitudeDelta);
		}
	}
}