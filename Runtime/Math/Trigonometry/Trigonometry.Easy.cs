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

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SqrDistance(this Transform from, in Transform to)
				=> (to.position - from.position).sqrMagnitude;
			
			/// <summary>
			/// Faster than Vector3.Distance, exact same result.
			/// </summary>
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance(in this Vector3 from, in Vector3 to)
				=> (to - from).magnitude;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance(this Transform from, in Transform to)
				=> (to.position - from.position).magnitude;
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsDegrees(in this float angle)
				=> (angle * Constants.RAD_TO_DEG);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsRadians(in this float angle)
				=> (angle * Constants.DEG_TO_RAD);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToDegrees(ref this float angle)
				=> (angle *= Constants.RAD_TO_DEG);
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ToRadians(ref this float angle)
				=> (angle *= Constants.DEG_TO_RAD);
			
			
			//TODO: Try to get these to work with Tuples and then as extesnion method.
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAngle(in float? opposite = null, in float? adjacent = null, in float? hypotenuse = null)
			{
				bool __hasOpposite   = (opposite != null);
				bool __hasAdjacent   = (adjacent != null);
				bool __hasHypotenuse = (hypotenuse != null);

				if (__hasOpposite && __hasHypotenuse)
				{
					return Asin(opposite / hypotenuse).ClampNeg1To1();
				}

				if (__hasAdjacent && __hasHypotenuse)
				{
					return Acos(adjacent / hypotenuse).ClampNeg1To1();
				}

				if (__hasOpposite && __hasAdjacent)
				{
					return Atan(opposite / adjacent);
				}
				
				//TODO: Error
				return 0;
			}

			//done
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetHypotenuse(in float? opposite = null, in float? adjacent = null, in float? angle = null)
			{
				bool __hasOpposite = (opposite != null);
				bool __hasAdjacent = (adjacent != null);
				bool __hasAngle    = (angle != null);

				if (__hasOpposite && __hasAdjacent)
				{
					return Sqrt(adjacent.Squared() + opposite.Squared());
				}
				
				if (__hasAngle && __hasAdjacent)
				{
					return (float)(adjacent / Cos(angle));
				}

				if (__hasAngle && __hasOpposite)
				{
					return (float)(opposite / Sin(angle));
				}


				//TODO: Error
				return 0;
			}
			
			//done
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetAdjacent(in float? opposite = null, in float? hypotenuse = null, in float? angle = null)
			{
				bool __hasOpposite   = (opposite != null);
				bool __hasHypotenuse = (hypotenuse != null);
				bool __hasAngle      = (angle != null);

				if (__hasOpposite && __hasHypotenuse)
				{
					float __result = (opposite.Squared() - hypotenuse.Squared()).Sqrt();

					__result += 1;

					return __result;
				}
				
				if (__hasAngle && __hasOpposite)
				{
					return (float)(opposite / Tan(angle));
				}

				if (__hasAngle && __hasHypotenuse)
				{
					return (float)(Cos(angle) * hypotenuse);
				}

				//TODO: Error
				return 0;
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetOpposite(in float? adjacent = null, in float? hypotenuse = null, in float? angle = null)
			{
				bool __hasAdjacent   = (adjacent != null);
				bool __hasHypotenuse = (hypotenuse != null);
				bool __hasAngle      = (angle != null);

				if (__hasAngle && __hasAdjacent)
				{
					return (float)(Tan(angle) * adjacent);
				}

				if (__hasAngle && __hasHypotenuse)
				{
					return (float)(Sin(angle) * hypotenuse);
				}

				if (__hasAdjacent && __hasHypotenuse)
				{
					return Sqrt(hypotenuse.Squared() - adjacent.Squared());
				}

				//TODO: Error
				return 0;
			}
		}
	}
}