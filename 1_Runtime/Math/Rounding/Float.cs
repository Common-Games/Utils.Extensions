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
		public static partial class Rounding
		{
			[PublicAPI]
			public enum Mode : U8
			{
				Nearest,
				Up,
				Down
			}

			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static F32 Round(this F32 value, in Mode roundingMode)
			{
				return roundingMode switch
				{
					Mode.Nearest => Mathf.Round(value),
					Mode.Down    => Mathf.Floor(value),
					Mode.Up      => Mathf.Ceil(value),
					_ => throw new ArgumentOutOfRangeException(paramName: nameof(roundingMode), actualValue: roundingMode, message: null)
				};
			}
			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 RoundToInt(this F32 value, Mode roundingMode)
			{
				return roundingMode switch
				{
					Mode.Nearest => Mathf.RoundToInt(value),
					Mode.Down    => Mathf.FloorToInt(value),
					Mode.Up      => Mathf.CeilToInt(value),
					_ => throw new ArgumentOutOfRangeException(paramName: nameof(roundingMode), actualValue: roundingMode, message: null)
				};
			}
			
			[PublicAPI]
				[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
				public static F32 Round(this F32 value)
				=> Mathf.Round(value);
			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static F32 Round2(this F32 value)
				=> (F32)System.Math.Round(a: value);
			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 RoundToInt(this F32 value)
				=> Mathf.RoundToInt(value);

			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static F32 Floor(this F32 value)
				=> Mathf.Floor(value);
			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 FloorToInt(this F32 value)
				=> Mathf.FloorToInt(value);

			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static F32 Ceil(this F32 value)
				=> Mathf.Ceil(value);
			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 CeilToInt(this F32 value)
				=> Mathf.CeilToInt(value);

			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 ClosestPowerOfTwo(this F32 value)
				=> Mathf.ClosestPowerOfTwo(value: Mathf.RoundToInt(value));
			
			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 NextPowerOfTwo(this F32 value)
				=> Mathf.NextPowerOfTwo(value: Mathf.RoundToInt(value));

			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 PreviousPowerOfTwo(this F32 value)
			{
				I32 __valueRoundedToInt = Mathf.RoundToInt(value);
				
				if (__valueRoundedToInt == 0) 
				{
					return 0;
				}
				
				__valueRoundedToInt |= (__valueRoundedToInt >> 1);
				__valueRoundedToInt |= (__valueRoundedToInt >> 2);
				__valueRoundedToInt |= (__valueRoundedToInt >> 4);
				__valueRoundedToInt |= (__valueRoundedToInt >> 8);
				__valueRoundedToInt |= (__valueRoundedToInt >> 16);
				return __valueRoundedToInt - (__valueRoundedToInt >> 1);
			}

			[PublicAPI]
			[MethodImpl(methodImplOptions: MethodImplOptions.AggressiveInlining)]
			public static I32 ToPowerOfTwo(this F32 value, Mode mode)
			{
				return mode switch
				{
					Mode.Nearest => ClosestPowerOfTwo(value),
					Mode.Down    => PreviousPowerOfTwo(value),
					Mode.Up      => NextPowerOfTwo(value),
					_ => throw new ArgumentOutOfRangeException(paramName: nameof(mode), actualValue: mode, message: null)
				};
			}

		}
	}
}