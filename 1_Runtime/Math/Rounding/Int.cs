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
		public static partial class Rounding
		{
			[MethodImpl(INLINE)]
			public static I32 ClosestPowerOfTwo(this I32 value)
				=> Mathf.ClosestPowerOfTwo(value: value);
			
			[MethodImpl(INLINE)]
			public static I32 NextPowerOfTwo(this I32 value)
				=> Mathf.NextPowerOfTwo(value: value);
			
			[MethodImpl(INLINE)]
			public static I32 PreviousPowerOfTwo(this I32 value)
			{
				if (value == 0) return 0;

				value |= (value >> 1);
				value |= (value >> 2);
				value |= (value >> 4);
				value |= (value >> 8);
				value |= (value >> 16);
				return value - (value >> 1);
			}
			
			[MethodImpl(INLINE)]
			public static I32 ToPowerOfTwo(this I32 value, Mode roundingMode)
			{
				return roundingMode switch
				{
					Mode.Nearest => ClosestPowerOfTwo(value),
					Mode.Down    => PreviousPowerOfTwo(value),
					Mode.Up      => NextPowerOfTwo(value),
					_ => throw new ArgumentOutOfRangeException(nameof(roundingMode), roundingMode, null)
				};
			}

		}
	}
}