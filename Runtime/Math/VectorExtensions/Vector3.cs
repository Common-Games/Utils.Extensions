using System;
using System.Runtime.CompilerServices;

using UnityEngine;

using JetBrains.Annotations;

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
		public static partial class VectorExtensions
		{
			/// <summary> Use this to compare two <see cref="Vector3"/>s. </summary>
			/// <param name="self"></param>
			/// <param name="compareTo"></param>
			/// <returns></returns>
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Boolean Approx(in this Vector3 self, in Vector3 compareTo) 
				=> (self.x.Approx(compareTo.x) && 
					self.y.Approx(compareTo.y) && 
					self.z.Approx(compareTo.z));
            
		}
	}
}