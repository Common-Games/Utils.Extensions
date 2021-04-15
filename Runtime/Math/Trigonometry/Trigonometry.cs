using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public static partial class Trigonometry
		{

			#region Power

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow(in this float value, in float power) 
				=> (float)System.Math.Pow(value, power);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow(in this int value, in float power) 
				=> (float)System.Math.Pow(value, power);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt(in this float value)
				=> (float)System.Math.Sqrt(value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Squared(in this float value)
				=> (value * value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cubed(in this float value)
				=> (value * value * value);

			#endregion

			#region Trigonometry

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin(in this float value)
				=> (float)System.Math.Sin(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos(in this float value)
				=> (float)System.Math.Cos(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan(in this float value)
				=> (float)System.Math.Tan(value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin(in this float value)
				=> (float)System.Math.Asin(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos(in this float value)
				=> (float)System.Math.Acos(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan(in this float value)
				=> (float)System.Math.Atan(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2(in this float y, in float x)
				=> (float)System.Math.Atan2(y: y, x: x);
			
			#endregion


			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp(in this float power)
				=> Mathf.Exp(power);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow(in this float? value, in float power) 
				=> Pow((float)value, power);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Squared(in this float? value)
				//=> (float)(value * value);
			{
				float __value = (float) value;
				
				return (__value * __value);
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cubed(in this float? value)
				=> (float)(value * value * value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt(in this float? value) 
				=> Sqrt((float)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin(in this float? value)
				=> Sin((float)value);
			
						
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos(in this float? value) 
				=> Cos((float)value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan(in this float? value)
				=> Tan((float)value);
			
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin(in this float? value)
				=> Asin((float)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos(in this float? value)
				=> Acos((float)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan(in this float? value)
				=> Atan((float)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2(in this float? y, in float? x)
				=> Atan2(y: (float)y, x: (float)x);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp(in this float? power)
				=> Mathf.Exp((float)power);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToAngle(in this Vector2 value) //custom
				=> Mathf.Atan2(x: value.x, y: value.y);
		}
	}
}