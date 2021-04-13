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
			public static float Pow(in this float value, in float power) 
				=> Mathf.Pow(f: value, p: power);
		
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt(in this float value) 
				=> Mathf.Sqrt(value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Square(in this float value)
				=> (value * value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cube(in this float value)
				=> (value * value * value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin(in this float value)
				=> Mathf.Sin(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin(in this float value)
				=> Mathf.Asin(value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos(in this float value)
				=> Mathf.Cos(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos(in this float value)
				=> Mathf.Acos(value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan(in this float value)
				=> Mathf.Tan(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan(in this float value)
				=> Mathf.Atan(value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2(in this float y, in float x)
				=> Mathf.Atan2(y: y, x: x);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp(in this float power)
				=> Mathf.Exp(power);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToAngle(in this Vector2 value) //custom
				=> Mathf.Atan2(x: value.x, y: value.y);
		}
	}
}