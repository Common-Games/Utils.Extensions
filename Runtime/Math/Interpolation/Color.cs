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
			public static Color Lerp(in this Color from, in Color to, in float t)
				=> Color.Lerp(a: from, b: to, t: t);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Color LerpUnclamped(in this Color from, in Color to, in float t)
				=> Color.LerpUnclamped(a: from, b: to, t: t);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 LerpInverse(in this Color value, in Color from, in Color to)
			{
				float r = Mathf.InverseLerp(a: from.r, b: to.r, value: value.r);
				float g = Mathf.InverseLerp(a: from.g, b: to.g, value: value.g);
				float b = Mathf.InverseLerp(a: from.b, b: to.b, value: value.b);

				return new Vector3(r, g, b);
			}
		}
	}
}