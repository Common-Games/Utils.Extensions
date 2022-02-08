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
			public static I32 Lerp(this I32 from, in I32 to, in F32 t)
				=> Mathf.Lerp(a: from, b: to, t: t).RoundToInt();
			
			[MethodImpl(INLINE)]
			public static I32 LerpUnclamped(this I32 from, in I32 to, in F32 t)
				=> Mathf.LerpUnclamped(a: from, b: to, t: t).RoundToInt();
	
			//[PublicAPI]
			//[MethodImpl(INLINE)]
			//public static float InverseLerp(this int value, in int from, in int to)
				//=> Mathf.InverseLerp(a: from, b: to, value: value);
				
			[MethodImpl(INLINE)]
			public static I32 LerpAngle(this I32 from, in I32 to, in F32 t)
				=> Mathf.LerpAngle(a: from, b: to, t: t).RoundToInt();
		}
	}
}