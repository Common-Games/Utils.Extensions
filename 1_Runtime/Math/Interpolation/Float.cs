using System;
using System.Runtime.CompilerServices;

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
			public static Single Lerp(ref this Single from, in Single to, in Single t)
				=> Mathf.Lerp(a: from, b: to, t: t);
			
			[MethodImpl(INLINE)]
			public static Single LerpUnclamped(ref this Single from, in Single to, in Single t)
				=> Mathf.LerpUnclamped(a: from, b: to, t: t);
			
			[MethodImpl(INLINE)]
			public static Single InverseLerp(ref this Single value, in Single from, in Single to)
				=> Mathf.InverseLerp(a: from, b: to, value: value);
			
			[MethodImpl(INLINE)]
			public static Single LerpAngle(ref this Single from, in Single to, in Single t)
				=> Mathf.LerpAngle(a: from, b: to, t: t);

			
			[MethodImpl(INLINE)]
			public static Single MoveTowards(ref this Single current, in Single target, in Single maxDelta)
				=> Mathf.MoveTowards(current: current, target: target, maxDelta: maxDelta);
			
			[MethodImpl(INLINE)]
			public static Single MoveTowardsAngle(ref this Single current, in Single target, in Single maxDelta)
				=> Mathf.MoveTowardsAngle(current: current, target: target, maxDelta: maxDelta);
			
		}
	}
}