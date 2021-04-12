using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public static partial class Rounding
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int ClosestPowerOfTwo(this int value)
				=> Mathf.ClosestPowerOfTwo(value: value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int NextPowerOfTwo(this int value)
				=> Mathf.NextPowerOfTwo(value: value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int PreviousPowerOfTwo(this int value)
			{
				if (value == 0) 
				{
					return 0;
				}
				
				value |= (value >> 1);
				value |= (value >> 2);
				value |= (value >> 4);
				value |= (value >> 8);
				value |= (value >> 16);
				return value - (value >> 1);
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int ToPowerOfTwo(this int value, in Mode roundingMode)
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