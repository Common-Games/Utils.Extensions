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
			public static float Lerp(this float from, in float to, in float t)
				=> Mathf.Lerp(a: from, b: to, t: t);
	
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LerpUnclamped(this float from, in float to, in float t)
				=> Mathf.LerpUnclamped(a: from, b: to, t: t);
	
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerp(this float value, in float from, in float to)
				=> Mathf.InverseLerp(a: from, b: to, value: value);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LerpAngle(this float from, in float to, in float t)
				=> Mathf.LerpAngle(a: from, b: to, t: t);

			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float MoveTowards(this float current, in float target, in float maxDelta)
				=> Mathf.MoveTowards(current: current, target: target, maxDelta: maxDelta);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float MoveTowardsAngle(this float current, in float target, in float maxDelta)
				=> Mathf.MoveTowardsAngle(current: current, target: target, maxDelta: maxDelta);
		}
	}
}