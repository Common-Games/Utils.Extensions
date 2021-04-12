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
			public enum Mode
			{
				Nearest,
				Up,
				Down
			}

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Round(this float value, in Mode roundingMode)
			{
				return roundingMode switch
				{
					Mode.Nearest => Mathf.Round(value),
					Mode.Down    => Mathf.Floor(value),
					Mode.Up      => Mathf.Ceil( value),
					_ => throw new ArgumentOutOfRangeException(nameof(roundingMode), roundingMode, null)
				};
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int RoundToInt(this float value, in Mode roundingMode)
			{
				return roundingMode switch
				{
					Mode.Nearest => Mathf.RoundToInt(f: value),
					Mode.Down    => Mathf.FloorToInt(f: value),
					Mode.Up      => Mathf.CeilToInt(f:  value),
					_ => throw new ArgumentOutOfRangeException(nameof(roundingMode), roundingMode, null)
				};
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Round(this float value)
				=> Mathf.Round(f: value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int RoundToInt(this float value)
				=> Mathf.RoundToInt(f: value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Floor(this float value)
				=> Mathf.Floor(f: value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FloorToInt(this float value)
				=> Mathf.FloorToInt(f: value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ceil(this float value)
				=> Mathf.Ceil(f: value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int CeilToInt(this float value)
				=> Mathf.CeilToInt(f: value);

			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int ClosestPowerOfTwo(this float value)
				=> Mathf.ClosestPowerOfTwo(value: Mathf.RoundToInt(value));
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int NextPowerOfTwo(this float value)
				=> Mathf.NextPowerOfTwo(value: Mathf.RoundToInt(value));

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int PreviousPowerOfTwo(this float value)
			{
				int __valueRoundedToInt = Mathf.RoundToInt(value);
				
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
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int ToPowerOfTwo(this float value, in Mode roundingMode)
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