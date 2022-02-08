using System;

using NUnit.Framework;

using UnityEngine;

namespace CGTK.Utils.Extensions
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
		public sealed class RoundingTests
		{
			#region Built-in

			[Test]
			public void Rounding_Float_Round()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				F32 __resultA = __A.Round();
				F32 __resultB = __B.Round();
				F32 __resultC = __C.Round();
				F32 __resultD = __D.Round();
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[Test]
			public void Rounding_Float_RoundToInt()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				I32 __resultA = __A.RoundToInt();
				I32 __resultB = __B.RoundToInt();
				I32 __resultC = __C.RoundToInt();
				I32 __resultD = __D.RoundToInt();
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}

			[Test]
			public void Rounding_Float_Ceil()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				F32 __resultA = __A.Ceil();
				F32 __resultB = __B.Ceil();
				F32 __resultC = __C.Ceil();
				F32 __resultD = __D.Ceil();
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[Test]
			public void Rounding_Float_CeilToInt()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				I32 __resultA = __A.CeilToInt();
				I32 __resultB = __B.CeilToInt();
				I32 __resultC = __C.CeilToInt();
				I32 __resultD = __D.CeilToInt();
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			[Test]
			public void Rounding_Float_Floor()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				F32 __resultA = __A.Floor();
				F32 __resultB = __B.Floor();
				F32 __resultC = __C.Floor();
				F32 __resultD = __D.Floor();
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			[Test]
			public void Rounding_Float_FloorToInt()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				I32 __resultA = __A.FloorToInt();
				I32 __resultB = __B.FloorToInt();
				I32 __resultC = __C.FloorToInt();
				I32 __resultD = __D.FloorToInt();
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			
			#endregion

			#region With Mode

			[Test]
			public void Rounding_Float_Round_Mode_Nearest()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				F32 __resultA = __A.Round(Rounding.Mode.Nearest);
				F32 __resultB = __B.Round(Rounding.Mode.Nearest);
				F32 __resultC = __C.Round(Rounding.Mode.Nearest);
				F32 __resultD = __D.Round(Rounding.Mode.Nearest);
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[Test]
			public void Rounding_Float_RoundToInt_Mode_Nearest()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				I32 __resultA = __A.RoundToInt(Rounding.Mode.Nearest);
				I32 __resultB = __B.RoundToInt(Rounding.Mode.Nearest);
				I32 __resultC = __C.RoundToInt(Rounding.Mode.Nearest);
				I32 __resultD = __D.RoundToInt(Rounding.Mode.Nearest);
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			[Test]
			public void Rounding_Float_Round_Mode_Up()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				F32 __resultA = __A.Round(Rounding.Mode.Up);
				F32 __resultB = __B.Round(Rounding.Mode.Up);
				F32 __resultC = __C.Round(Rounding.Mode.Up);
				F32 __resultD = __D.Round(Rounding.Mode.Up);
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[Test]
			public void Rounding_Float_RoundToInt_Mode_Up()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				I32 __resultA = __A.RoundToInt(Rounding.Mode.Up);
				I32 __resultB = __B.RoundToInt(Rounding.Mode.Up);
				I32 __resultC = __C.RoundToInt(Rounding.Mode.Up);
				I32 __resultD = __D.RoundToInt(Rounding.Mode.Up);
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			
			[Test]
			public void Rounding_Float_Round_Mode_Down()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				F32 __resultA = __A.Round(Rounding.Mode.Down);
				F32 __resultB = __B.Round(Rounding.Mode.Down);
				F32 __resultC = __C.Round(Rounding.Mode.Down);
				F32 __resultD = __D.Round(Rounding.Mode.Down);
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			[Test]
			public void Rounding_Float_RoundToInt_Mode_Down()
			{
				const F32 __A = 0.45f;
				const F32 __B = 0.5642f;
				const F32 __C = 2.2642f;
				const F32 __D = -1.2642f;

				I32 __resultA = __A.RoundToInt(Rounding.Mode.Down);
				I32 __resultB = __B.RoundToInt(Rounding.Mode.Down);
				I32 __resultC = __C.RoundToInt(Rounding.Mode.Down);
				I32 __resultD = __D.RoundToInt(Rounding.Mode.Down);
				
				Debug.Log(message: $"A = {__resultA}");
				Debug.Log(message: $"B = {__resultB}");
				Debug.Log(message: $"C = {__resultC}");
				Debug.Log(message: $"D = {__resultD}");

				//yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			
			#endregion

			#region PowerOfTwo

			[Test]
			public void Rounding_Float_PowerOfTwo_Closest()
			{
				const F32 __A = 7.1f;
				const F32 __B = 139.3f;
				const F32 __C = 4.1f;
				const F32 __D = 254f;
				const F32 __E = 256f;
				const F32 __F = 0f;
				const F32 __G = -1.2642f;

				F32 __resultA = __A.ClosestPowerOfTwo();
				F32 __resultB = __B.ClosestPowerOfTwo();
				F32 __resultC = __C.ClosestPowerOfTwo();
				F32 __resultD = __D.ClosestPowerOfTwo();
				F32 __resultE = __E.ClosestPowerOfTwo();
				F32 __resultF = __F.ClosestPowerOfTwo();
				F32 __resultG = __G.ClosestPowerOfTwo();
				
				Debug.Log(message: $"A = Input: {__A}, Output: {__resultA}");
				Debug.Log(message: $"B = Input: {__B}, Output: {__resultB}");
				Debug.Log(message: $"C = Input: {__C}, Output: {__resultC}");
				Debug.Log(message: $"D = Input: {__D}, Output: {__resultD}");
				Debug.Log(message: $"E = Input: {__E}, Output: {__resultE}");
				Debug.Log(message: $"F = Input: {__F}, Output: {__resultF}");
				Debug.Log(message: $"F = Input: {__G}, Output: {__resultG}");

				//yield return null;

				Assert.AreEqual(actual: __resultA, expected: 8);
				Assert.AreEqual(actual: __resultB, expected: 128);
				Assert.AreEqual(actual: __resultC, expected: 4);
				Assert.AreEqual(actual: __resultD, expected: 256);
				Assert.AreEqual(actual: __resultE, expected: 256);
				Assert.AreEqual(actual: __resultF, expected: 0);
				Assert.AreEqual(actual: __resultG, expected: 0);
			}
			
			[Test]
			public void Rounding_Float_PowerOfTwo_Next()
			{
				const F32 __A = 7.1f;
				const F32 __B = 139.3f;
				const F32 __C = 4.1f;
				const F32 __D = 254f;
				const F32 __E = 256f;
				const F32 __F = 0f;
				const F32 __G = -1.2642f;

				F32 __resultA = __A.NextPowerOfTwo();
				F32 __resultB = __B.NextPowerOfTwo();
				F32 __resultC = __C.NextPowerOfTwo();
				F32 __resultD = __D.NextPowerOfTwo();
				F32 __resultE = __E.NextPowerOfTwo();
				F32 __resultF = __F.NextPowerOfTwo();
				F32 __resultG = __G.NextPowerOfTwo();
				
				Debug.Log(message: $"A = Input: {__A}, Output: {__resultA}");
				Debug.Log(message: $"B = Input: {__B}, Output: {__resultB}");
				Debug.Log(message: $"C = Input: {__C}, Output: {__resultC}");
				Debug.Log(message: $"D = Input: {__D}, Output: {__resultD}");
				Debug.Log(message: $"E = Input: {__E}, Output: {__resultE}");
				Debug.Log(message: $"F = Input: {__F}, Output: {__resultF}");
				Debug.Log(message: $"F = Input: {__G}, Output: {__resultG}");

				//yield return null;

				Assert.AreEqual(actual: __resultA, expected: 8);
				Assert.AreEqual(actual: __resultB, expected: 256);
				Assert.AreEqual(actual: __resultC, expected: 4);
				Assert.AreEqual(actual: __resultD, expected: 256);
				Assert.AreEqual(actual: __resultE, expected: 256);
				Assert.AreEqual(actual: __resultF, expected: 0);
				Assert.AreEqual(actual: __resultG, expected: 0);
			}
			
			[Test]
			public void Rounding_Float_PowerOfTwo_Previous()
			{
				const F32 __A = 7.1f;
				const F32 __B = 139.3f;
				const F32 __C = 4.1f;
				const F32 __D = 254f;
				const F32 __E = 256f;
				const F32 __F = 0f;
				const F32 __G = -1.2642f;

				F32 __resultA = __A.PreviousPowerOfTwo();
				F32 __resultB = __B.PreviousPowerOfTwo();
				F32 __resultC = __C.PreviousPowerOfTwo();
				F32 __resultD = __D.PreviousPowerOfTwo();
				F32 __resultE = __E.PreviousPowerOfTwo();
				F32 __resultF = __F.PreviousPowerOfTwo();
				F32 __resultG = __G.PreviousPowerOfTwo();
				
				Debug.Log(message: $"A = Input: {__A}, Output: {__resultA}");
				Debug.Log(message: $"B = Input: {__B}, Output: {__resultB}");
				Debug.Log(message: $"C = Input: {__C}, Output: {__resultC}");
				Debug.Log(message: $"D = Input: {__D}, Output: {__resultD}");
				Debug.Log(message: $"E = Input: {__E}, Output: {__resultE}");
				Debug.Log(message: $"F = Input: {__F}, Output: {__resultF}");
				Debug.Log(message: $"F = Input: {__G}, Output: {__resultG}");

				//yield return null;

				Assert.AreEqual(actual: __resultA, expected: 4);
				Assert.AreEqual(actual: __resultB, expected: 128);
				Assert.AreEqual(actual: __resultC, expected: 4);
				Assert.AreEqual(actual: __resultD, expected: 128);
				Assert.AreEqual(actual: __resultE, expected: 256);
				Assert.AreEqual(actual: __resultF, expected: 0);
				Assert.AreEqual(actual: __resultG, expected: 0);
			}
			
			
			[Test]
			public void Rounding_Float_PowerOfTwo_Mode_Nearest()
			{
				const F32 __A = 7.1f;
				const F32 __B = 139.3f;
				const F32 __C = 4.1f;
				const F32 __D = 254f;
				const F32 __E = 256f;
				const F32 __F = 0f;
				const F32 __G = -1.2642f;

				F32 __resultA = __A.ToPowerOfTwo(Rounding.Mode.Nearest);
				F32 __resultB = __B.ToPowerOfTwo(Rounding.Mode.Nearest);
				F32 __resultC = __C.ToPowerOfTwo(Rounding.Mode.Nearest);
				F32 __resultD = __D.ToPowerOfTwo(Rounding.Mode.Nearest);
				F32 __resultE = __E.ToPowerOfTwo(Rounding.Mode.Nearest);
				F32 __resultF = __F.ToPowerOfTwo(Rounding.Mode.Nearest);
				F32 __resultG = __G.ToPowerOfTwo(Rounding.Mode.Nearest);
				
				Debug.Log(message: $"A = Input: {__A}, Output: {__resultA}");
				Debug.Log(message: $"B = Input: {__B}, Output: {__resultB}");
				Debug.Log(message: $"C = Input: {__C}, Output: {__resultC}");
				Debug.Log(message: $"D = Input: {__D}, Output: {__resultD}");
				Debug.Log(message: $"E = Input: {__E}, Output: {__resultE}");
				Debug.Log(message: $"F = Input: {__F}, Output: {__resultF}");
				Debug.Log(message: $"F = Input: {__G}, Output: {__resultG}");

				//yield return null;

				Assert.AreEqual(actual: __resultA, expected: 8);
				Assert.AreEqual(actual: __resultB, expected: 128);
				Assert.AreEqual(actual: __resultC, expected: 4);
				Assert.AreEqual(actual: __resultD, expected: 256);
				Assert.AreEqual(actual: __resultE, expected: 256);
				Assert.AreEqual(actual: __resultF, expected: 0);
				Assert.AreEqual(actual: __resultG, expected: 0);
			}
			
			[Test]
			public void Rounding_Float_PowerOfTwo_Mode_Up()
			{
				const F32 __A = 7.1f;
				const F32 __B = 139.3f;
				const F32 __C = 4.1f;
				const F32 __D = 254f;
				const F32 __E = 256f;
				const F32 __F = 0f;
				const F32 __G = -1.2642f;

				F32 __resultA = __A.ToPowerOfTwo(Rounding.Mode.Up);
				F32 __resultB = __B.ToPowerOfTwo(Rounding.Mode.Up);
				F32 __resultC = __C.ToPowerOfTwo(Rounding.Mode.Up);
				F32 __resultD = __D.ToPowerOfTwo(Rounding.Mode.Up);
				F32 __resultE = __E.ToPowerOfTwo(Rounding.Mode.Up);
				F32 __resultF = __F.ToPowerOfTwo(Rounding.Mode.Up);
				F32 __resultG = __G.ToPowerOfTwo(Rounding.Mode.Up);
				
				Debug.Log(message: $"A = Input: {__A}, Output: {__resultA}");
				Debug.Log(message: $"B = Input: {__B}, Output: {__resultB}");
				Debug.Log(message: $"C = Input: {__C}, Output: {__resultC}");
				Debug.Log(message: $"D = Input: {__D}, Output: {__resultD}");
				Debug.Log(message: $"E = Input: {__E}, Output: {__resultE}");
				Debug.Log(message: $"F = Input: {__F}, Output: {__resultF}");
				Debug.Log(message: $"F = Input: {__G}, Output: {__resultG}");

				//yield return null;

				Assert.AreEqual(actual: __resultA, expected: 8);
				Assert.AreEqual(actual: __resultB, expected: 256);
				Assert.AreEqual(actual: __resultC, expected: 4);
				Assert.AreEqual(actual: __resultD, expected: 256);
				Assert.AreEqual(actual: __resultE, expected: 256);
				Assert.AreEqual(actual: __resultF, expected: 0);
				Assert.AreEqual(actual: __resultG, expected: 0);
			}
			
			[Test]
			public void Rounding_Float_PowerOfTwo_Mode_Down()
			{
				const F32 __A = 7.1f;
				const F32 __B = 139.3f;
				const F32 __C = 4.1f;
				const F32 __D = 254f;
				const F32 __E = 256f;
				const F32 __F = 0f;
				const F32 __G = -1.2642f;

				F32 __resultA = __A.ToPowerOfTwo(Rounding.Mode.Down);
				F32 __resultB = __B.ToPowerOfTwo(Rounding.Mode.Down);
				F32 __resultC = __C.ToPowerOfTwo(Rounding.Mode.Down);
				F32 __resultD = __D.ToPowerOfTwo(Rounding.Mode.Down);
				F32 __resultE = __E.ToPowerOfTwo(Rounding.Mode.Down);
				F32 __resultF = __F.ToPowerOfTwo(Rounding.Mode.Down);
				F32 __resultG = __G.ToPowerOfTwo(Rounding.Mode.Down);
				
				Debug.Log(message: $"A = Input: {__A}, Output: {__resultA}");
				Debug.Log(message: $"B = Input: {__B}, Output: {__resultB}");
				Debug.Log(message: $"C = Input: {__C}, Output: {__resultC}");
				Debug.Log(message: $"D = Input: {__D}, Output: {__resultD}");
				Debug.Log(message: $"E = Input: {__E}, Output: {__resultE}");
				Debug.Log(message: $"F = Input: {__F}, Output: {__resultF}");
				Debug.Log(message: $"F = Input: {__G}, Output: {__resultG}");

				//yield return null;

				Assert.AreEqual(actual: __resultA, expected: 4);
				Assert.AreEqual(actual: __resultB, expected: 128);
				Assert.AreEqual(actual: __resultC, expected: 4);
				Assert.AreEqual(actual: __resultD, expected: 128);
				Assert.AreEqual(actual: __resultE, expected: 256);
				Assert.AreEqual(actual: __resultF, expected: 0);
				Assert.AreEqual(actual: __resultG, expected: 0);
			}
			
			#endregion
		}
	}
}