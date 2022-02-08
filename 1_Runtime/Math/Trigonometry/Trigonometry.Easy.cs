using System;
using System.Runtime.CompilerServices;

using UnityEngine;
//using static CGTK.Utils.Extensions.MathematicalConstants;

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
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
			[MethodImpl(INLINE)]
			public static F32 SqrDistance(in this Vector3 from, in Vector3 to)
				=> (to - from).sqrMagnitude;
			
			[MethodImpl(INLINE)]
			public static F32 SqrDistance(this Transform from, in Transform to)
				=> (to.position - from.position).sqrMagnitude;
			
			/// <summary>
			/// Faster than Vector3.Distance, exact same result.
			/// </summary>
			[MethodImpl(INLINE)]
			public static F32 Distance(in this Vector3 from, in Vector3 to)
				=> (to - from).magnitude;
			
			[MethodImpl(INLINE)]
			public static F32 Distance(this Transform from, in Transform to)
				=> (to.position - from.position).magnitude;
			
			[MethodImpl(INLINE)]
			public static F32 AsDegrees(in this F32 angle)
				=> (angle * Constants.RAD_TO_DEG);
			
			[MethodImpl(INLINE)]
			public static F32 AsRadians(in this F32 angle)
				=> (angle * Constants.DEG_TO_RAD);
			
			[MethodImpl(INLINE)]
			public static F32 ToDegrees(ref this F32 angle)
				=> (angle *= Constants.RAD_TO_DEG);
			
			[MethodImpl(INLINE)]
			public static F32 ToRadians(ref this F32 angle)
				=> (angle *= Constants.DEG_TO_RAD);
			
			
			//TODO: Try to get these to work with Tuples and then as extesnion method.
			
			[MethodImpl(INLINE)]
			public static F32 GetAngle(in F32? opposite = null, in F32? adjacent = null, in F32? hypotenuse = null)
			{
				Boolean __hasOpposite   = (opposite != null);
				Boolean __hasAdjacent   = (adjacent != null);
				Boolean __hasHypotenuse = (hypotenuse != null);

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
			
			[MethodImpl(INLINE)]
			public static F32 GetHypotenuse(in F32? opposite = null, in F32? adjacent = null, in F32? angle = null)
			{
				Boolean __hasOpposite = (opposite != null);
				Boolean __hasAdjacent = (adjacent != null);
				Boolean __hasAngle    = (angle != null);

				if (__hasOpposite && __hasAdjacent)
				{
					return Sqrt(adjacent.Squared() + opposite.Squared());
				}
				
				if (__hasAngle && __hasAdjacent)
				{
					return (F32)(adjacent / Cos(angle));
				}

				if (__hasAngle && __hasOpposite)
				{
					return (F32)(opposite / Sin(angle));
				}


				//TODO: Error
				return 0;
			}
			
			[MethodImpl(INLINE)]
			public static F32 GetAdjacent(in F32? opposite = null, in F32? hypotenuse = null, in F32? angle = null)
			{
				Boolean __hasOpposite   = (opposite != null);
				Boolean __hasHypotenuse = (hypotenuse != null);
				Boolean __hasAngle      = (angle != null);

				if (__hasOpposite && __hasHypotenuse)
				{
					F32 __result = (opposite.Squared() - hypotenuse.Squared()).Sqrt();

					__result += 1;

					return __result;
				}
				
				if (__hasAngle && __hasOpposite)
				{
					return (F32)(opposite / Tan(angle));
				}

				if (__hasAngle && __hasHypotenuse)
				{
					return (F32)(Cos(angle) * hypotenuse);
				}

				//TODO: Error
				return 0;
			}
			
			[MethodImpl(INLINE)]
			public static F32 GetOpposite(in F32? adjacent = null, in F32? hypotenuse = null, in F32? angle = null)
			{
				Boolean __hasAdjacent   = (adjacent != null);
				Boolean __hasHypotenuse = (hypotenuse != null);
				Boolean __hasAngle      = (angle != null);

				if (__hasAngle && __hasAdjacent)
				{
					return (F32)(Tan(angle) * adjacent);
				}

				if (__hasAngle && __hasHypotenuse)
				{
					return (F32)(Sin(angle) * hypotenuse);
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