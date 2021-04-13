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
			public static float Pow(this float value, in float power) 
				=> Mathf.Pow(f: value, p: power);
		
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt(this float value) 
				=> Mathf.Sqrt(value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Square(this float value)
				=> (value * value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cube(this float value)
				=> (value * value * value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin(this float value)
				=> Mathf.Sin(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin(this float value)
				=> Mathf.Asin(value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos(this float value)
				=> Mathf.Cos(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos(this float value)
				=> Mathf.Acos(value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan(this float value)
				=> Mathf.Tan(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan(this float value)
				=> Mathf.Atan(value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2(this float y, in float x)
				=> Mathf.Atan2(y: y, x: x);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp(this float power)
				=> Mathf.Exp(power);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToAngle(this Vector2 value) //custom
				=> Mathf.Atan2(x: value.x, y: value.y);
		}
	}
}