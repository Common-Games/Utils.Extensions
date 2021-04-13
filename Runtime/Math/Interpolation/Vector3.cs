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
			public static Vector3 Lerp(this Vector3 from, in Vector3 to, in float t)
				=> Vector3.Lerp(a: from, b: to, t: t);
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 LerpUnclamped(this Vector3 from, in Vector3 to, in float t)
				=> Vector3.LerpUnclamped(a: from, b: to, t: t);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Slerp(this Vector3 from, in Vector3 to, in float t)
				=> Vector3.Slerp(a: from, b: to, t: t);
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 SlerpUnclamped(this Vector3 from, in Vector3 to, in float t)
				=> Vector3.SlerpUnclamped(a: from, b: to, t: t);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 MoveTowards(this Vector3 current, in Vector3 target, in float maxDistanceDelta)
				=> Vector3.MoveTowards(current: current, target: target, maxDistanceDelta: maxDistanceDelta);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 RotateTowards(this Vector3 current, in Vector3 target, in float maxRadiansDelta, in float maxMagnitudeDelta)
				=> Vector3.RotateTowards(current: current, target: target, maxRadiansDelta: maxRadiansDelta, maxMagnitudeDelta: maxMagnitudeDelta);
		}
	}
}