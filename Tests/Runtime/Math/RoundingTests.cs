using System.Collections;

using NUnit.Framework;
using Unity.PerformanceTesting;

using UnityEngine;
using UnityEngine.TestTools;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public sealed class RoundingTests
		{
			#region Built-in

			[Test]
			public void Rounding_Float_Round()
			{
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				float __resultA = __A.Round();
				float __resultB = __B.Round();
				float __resultC = __C.Round();
				float __resultD = __D.Round();
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				int __resultA = __A.RoundToInt();
				int __resultB = __B.RoundToInt();
				int __resultC = __C.RoundToInt();
				int __resultD = __D.RoundToInt();
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				float __resultA = __A.Ceil();
				float __resultB = __B.Ceil();
				float __resultC = __C.Ceil();
				float __resultD = __D.Ceil();
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				int __resultA = __A.CeilToInt();
				int __resultB = __B.CeilToInt();
				int __resultC = __C.CeilToInt();
				int __resultD = __D.CeilToInt();
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				float __resultA = __A.Floor();
				float __resultB = __B.Floor();
				float __resultC = __C.Floor();
				float __resultD = __D.Floor();
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				int __resultA = __A.FloorToInt();
				int __resultB = __B.FloorToInt();
				int __resultC = __C.FloorToInt();
				int __resultD = __D.FloorToInt();
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				float __resultA = __A.Round(Rounding.Mode.Nearest);
				float __resultB = __B.Round(Rounding.Mode.Nearest);
				float __resultC = __C.Round(Rounding.Mode.Nearest);
				float __resultD = __D.Round(Rounding.Mode.Nearest);
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				int __resultA = __A.RoundToInt(Rounding.Mode.Nearest);
				int __resultB = __B.RoundToInt(Rounding.Mode.Nearest);
				int __resultC = __C.RoundToInt(Rounding.Mode.Nearest);
				int __resultD = __D.RoundToInt(Rounding.Mode.Nearest);
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				float __resultA = __A.Round(Rounding.Mode.Up);
				float __resultB = __B.Round(Rounding.Mode.Up);
				float __resultC = __C.Round(Rounding.Mode.Up);
				float __resultD = __D.Round(Rounding.Mode.Up);
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				int __resultA = __A.RoundToInt(Rounding.Mode.Up);
				int __resultB = __B.RoundToInt(Rounding.Mode.Up);
				int __resultC = __C.RoundToInt(Rounding.Mode.Up);
				int __resultD = __D.RoundToInt(Rounding.Mode.Up);
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				float __resultA = __A.Round(Rounding.Mode.Down);
				float __resultB = __B.Round(Rounding.Mode.Down);
				float __resultC = __C.Round(Rounding.Mode.Down);
				float __resultD = __D.Round(Rounding.Mode.Down);
				
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
				const float __A = 0.45f;
				const float __B = 0.5642f;
				const float __C = 2.2642f;
				const float __D = -1.2642f;

				int __resultA = __A.RoundToInt(Rounding.Mode.Down);
				int __resultB = __B.RoundToInt(Rounding.Mode.Down);
				int __resultC = __C.RoundToInt(Rounding.Mode.Down);
				int __resultD = __D.RoundToInt(Rounding.Mode.Down);
				
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
				const float __A = 7.1f;
				const float __B = 139.3f;
				const float __C = 4.1f;
				const float __D = 254f;
				const float __E = 256f;
				const float __F = 0f;
				const float __G = -1.2642f;

				float __resultA = __A.ClosestPowerOfTwo();
				float __resultB = __B.ClosestPowerOfTwo();
				float __resultC = __C.ClosestPowerOfTwo();
				float __resultD = __D.ClosestPowerOfTwo();
				float __resultE = __E.ClosestPowerOfTwo();
				float __resultF = __F.ClosestPowerOfTwo();
				float __resultG = __G.ClosestPowerOfTwo();
				
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
				const float __A = 7.1f;
				const float __B = 139.3f;
				const float __C = 4.1f;
				const float __D = 254f;
				const float __E = 256f;
				const float __F = 0f;
				const float __G = -1.2642f;

				float __resultA = __A.NextPowerOfTwo();
				float __resultB = __B.NextPowerOfTwo();
				float __resultC = __C.NextPowerOfTwo();
				float __resultD = __D.NextPowerOfTwo();
				float __resultE = __E.NextPowerOfTwo();
				float __resultF = __F.NextPowerOfTwo();
				float __resultG = __G.NextPowerOfTwo();
				
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
				const float __A = 7.1f;
				const float __B = 139.3f;
				const float __C = 4.1f;
				const float __D = 254f;
				const float __E = 256f;
				const float __F = 0f;
				const float __G = -1.2642f;

				float __resultA = __A.PreviousPowerOfTwo();
				float __resultB = __B.PreviousPowerOfTwo();
				float __resultC = __C.PreviousPowerOfTwo();
				float __resultD = __D.PreviousPowerOfTwo();
				float __resultE = __E.PreviousPowerOfTwo();
				float __resultF = __F.PreviousPowerOfTwo();
				float __resultG = __G.PreviousPowerOfTwo();
				
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
				const float __A = 7.1f;
				const float __B = 139.3f;
				const float __C = 4.1f;
				const float __D = 254f;
				const float __E = 256f;
				const float __F = 0f;
				const float __G = -1.2642f;

				float __resultA = __A.ToPowerOfTwo(Rounding.Mode.Nearest);
				float __resultB = __B.ToPowerOfTwo(Rounding.Mode.Nearest);
				float __resultC = __C.ToPowerOfTwo(Rounding.Mode.Nearest);
				float __resultD = __D.ToPowerOfTwo(Rounding.Mode.Nearest);
				float __resultE = __E.ToPowerOfTwo(Rounding.Mode.Nearest);
				float __resultF = __F.ToPowerOfTwo(Rounding.Mode.Nearest);
				float __resultG = __G.ToPowerOfTwo(Rounding.Mode.Nearest);
				
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
				const float __A = 7.1f;
				const float __B = 139.3f;
				const float __C = 4.1f;
				const float __D = 254f;
				const float __E = 256f;
				const float __F = 0f;
				const float __G = -1.2642f;

				float __resultA = __A.ToPowerOfTwo(Rounding.Mode.Up);
				float __resultB = __B.ToPowerOfTwo(Rounding.Mode.Up);
				float __resultC = __C.ToPowerOfTwo(Rounding.Mode.Up);
				float __resultD = __D.ToPowerOfTwo(Rounding.Mode.Up);
				float __resultE = __E.ToPowerOfTwo(Rounding.Mode.Up);
				float __resultF = __F.ToPowerOfTwo(Rounding.Mode.Up);
				float __resultG = __G.ToPowerOfTwo(Rounding.Mode.Up);
				
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
				const float __A = 7.1f;
				const float __B = 139.3f;
				const float __C = 4.1f;
				const float __D = 254f;
				const float __E = 256f;
				const float __F = 0f;
				const float __G = -1.2642f;

				float __resultA = __A.ToPowerOfTwo(Rounding.Mode.Down);
				float __resultB = __B.ToPowerOfTwo(Rounding.Mode.Down);
				float __resultC = __C.ToPowerOfTwo(Rounding.Mode.Down);
				float __resultD = __D.ToPowerOfTwo(Rounding.Mode.Down);
				float __resultE = __E.ToPowerOfTwo(Rounding.Mode.Down);
				float __resultF = __F.ToPowerOfTwo(Rounding.Mode.Down);
				float __resultG = __G.ToPowerOfTwo(Rounding.Mode.Down);
				
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