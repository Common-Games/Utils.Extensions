using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public static partial class Trigonometry
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SqrDistance(in this Vector3 from, in Vector3 to)
				=> (to - from).sqrMagnitude;
			
			/// <summary>
			/// Faster than Vector3.Distance, exact same result.
			/// </summary>
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceFast(in this Vector3 from, in Vector3 to)
				=> (to - from).magnitude;
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToDegrees(ref this float angle)
				=> (angle * Constants.RAD_TO_DEG);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToRadians(ref this float angle)
				=> (angle * Constants.DEG_TO_RAD);
			

			[Flags]
			public enum Options
			{
				Angle = 1,
				Hypotenuse = 2,
				Adjacent = 4,
				Opposite = 8,
			}

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAngle(in float a, in float b, in (Options a, Options b) config)
				=> GetAngle((a, b), flags: (config.a | config.b));
			
			
			//done
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAngle(in this (float a, float b) input, in Options flags)
			{
				if (flags.HasFlag(flag: Options.Opposite | Options.Hypotenuse))
				{
					Debug.Log("A - 1");
					return Asin(input.a / input.b).ClampNeg1To1();
				}
				if (flags.HasFlag(flag: Options.Adjacent | Options.Hypotenuse))
				{
					Debug.Log("B - 2");
					return Acos(input.a / input.b).ClampNeg1To1();
				}
				if (flags.HasFlag(flag: Options.Opposite | Options.Adjacent))
				{
					Debug.Log("C - 3");
					return Atan(input.a / input.b);
				}

				Debug.Log("D - ERROR");
				//TODO: Error
				return 0;
			}

			//done
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetHypotenuse(in this (float a, float b) input, in Options flags)
			{
				if (flags.HasFlag(flag: Options.Angle | Options.Adjacent))
				{
					return (input.b / Cos(input.a));
				}
				if (flags.HasFlag(flag: Options.Angle | Options.Opposite))
				{
					return (input.b / Sin(input.a));
				}
				if (flags.HasFlag(flag: Options.Opposite | Options.Adjacent))
				{
					return Sqrt(input.b.Square() + input.a.Square());
				}

				//TODO: Error
				return 0;
			}
			
			//done
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAdjacent(in this (float a, float b) input, in Options flags)
			{
				if (flags.HasFlag(flag: Options.Angle | Options.Opposite))
				{
					return (input.b / Tan(input.a));
				}
				if (flags.HasFlag(flag: Options.Angle | Options.Hypotenuse))
				{
					return (Cos(input.a) * input.b);
				}
				if (flags.HasFlag(flag: Options.Opposite | Options.Hypotenuse))
				{
					return Sqrt(value: input.b.Square() - input.a.Square());
				}

				//TODO: Error
				return 0;
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetOpposite(in this (float a, float b) input, in Options flags)
			{
				if (flags.HasFlag(flag: Options.Angle | Options.Adjacent))
				{
					return (Tan(input.a) * input.b);
				}
				if (flags.HasFlag(flag: Options.Angle | Options.Hypotenuse))
				{
					return (Sin(input.a) * input.b);
				}
				if (flags.HasFlag(flag: Options.Adjacent | Options.Hypotenuse))
				{
					return Sqrt(value: input.b.Square() - input.a.Square());
				}

				//TODO: Error
				return 0;
			}
		}
	}
}