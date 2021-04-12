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
			public static UnityEngine.Vector3 LerpInverse(this Color value, in Color from, in Color to)
			{
				float r = Mathf.InverseLerp(a: from.r, b: to.r, value: value.r);
				float g = Mathf.InverseLerp(a: from.g, b: to.g, value: value.g);
				float b =  Mathf.InverseLerp(a: from.b, b: to.b, value: value.b);

				return new UnityEngine.Vector3(r, g, b);
			}
		}
	}
}