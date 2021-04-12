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
					Mode.Nearest => Mathf.Round(f: value),
					Mode.Down    => Mathf.Floor(f: value),
					Mode.Up      => Mathf.Ceil(f:  value),
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
			
		}
	}
}