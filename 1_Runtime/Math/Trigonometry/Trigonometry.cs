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
		public static partial class Trigonometry
		{

			#region Power

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Pow(in this F32 value, in F32 power) 
				=> (F32)System.Math.Pow(value, power);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Pow(in this I32 value, in F32 power) 
				=> (F32)System.Math.Pow(value, power);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Sqrt(in this F32 value)
				=> (F32)System.Math.Sqrt(value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Squared(in this F32 value)
				=> (value * value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Cubed(in this F32 value)
				=> (value * value * value);

			#endregion

			#region Trigonometry

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Sin(in this F32 value)
				=> (F32)System.Math.Sin(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Cos(in this F32 value)
				=> (F32)System.Math.Cos(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Tan(in this F32 value)
				=> (F32)System.Math.Tan(value);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Asin(in this F32 value)
				=> (F32)System.Math.Asin(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Acos(in this F32 value)
				=> (F32)System.Math.Acos(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Atan(in this F32 value)
				=> (F32)System.Math.Atan(value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Atan2(in this F32 y, in F32 x)
				=> (F32)System.Math.Atan2(y: y, x: x);
			
			#endregion


			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Exp(in this F32 power)
				=> (F32)System.Math.Exp(power);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Pow(in this F32? value, in F32 power) 
				=> Pow((F32)value, power);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Squared(in this F32? value)
				//=> (float)(value * value);
			{
				F32 __value = (F32) value;
				
				return (__value * __value);
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Cubed(in this F32? value)
				=> (F32)(value * value * value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Sqrt(in this F32? value) 
				=> Sqrt((F32)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Sin(in this F32? value)
				=> Sin((F32)value);
			
						
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Cos(in this F32? value) 
				=> Cos((F32)value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Tan(in this F32? value)
				=> Tan((F32)value);
			
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Asin(in this F32? value)
				=> Asin((F32)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Acos(in this F32? value)
				=> Acos((F32)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Atan(in this F32? value)
				=> Atan((F32)value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Atan2(in this F32? y, in F32? x)
				=> Atan2(y: (F32)y, x: (F32)x);
			
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 Exp(in this F32? power)
				=> Exp((F32)power);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static F32 ToAngle(in this Vector2 value) //custom
				=> Atan2(x: value.x, y: value.y);
		}
	}
}