using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public static partial class Interpolation
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Lerp(this int from, in int to, in float t)
				=> Mathf.Lerp(a: from, b: to, t: t).RoundToInt();
	
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int LerpUnclamped(this int from, in int to, in float t)
				=> Mathf.LerpUnclamped(a: from, b: to, t: t).RoundToInt();
	
			//[PublicAPI]
			//[MethodImpl(MethodImplOptions.AggressiveInlining)]
			//public static float InverseLerp(this int value, in int from, in int to)
				//=> Mathf.InverseLerp(a: from, b: to, value: value);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int LerpAngle(this int from, in int to, in float t)
				=> Mathf.LerpAngle(a: from, b: to, t: t).RoundToInt();
		}
	}
}