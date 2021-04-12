using System.Collections;

using NUnit.Framework;

using UnityEngine;
using UnityEngine.TestTools;

namespace CGTK.Utilities.Extensions
{
	using Math;

	namespace Tests
	{
		public sealed class RoundingTests
		{
			[UnityTest]
			public IEnumerator Rounding_Float_Round()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[UnityTest]
			public IEnumerator Rounding_Float_RoundToInt()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			[UnityTest]
			public IEnumerator Rounding_Float_Ceil()
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

				yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[UnityTest]
			public IEnumerator Rounding_Float_CeilToInt()
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

				yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			[UnityTest]
			public IEnumerator Rounding_Float_Floor()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			[UnityTest]
			public IEnumerator Rounding_Float_FloorToInt()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}

			#region With Mode

			[UnityTest]
			public IEnumerator Rounding_Float_Round_Mode_Nearest()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[UnityTest]
			public IEnumerator Rounding_Float_RoundToInt_Mode_Nearest()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			[UnityTest]
			public IEnumerator Rounding_Float_Round_Mode_Up()
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

				yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			[UnityTest]
			public IEnumerator Rounding_Float_RoundToInt_Mode_Up()
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

				yield return null;

				Assert.AreEqual(expected: 1, actual: __resultA);
				Assert.AreEqual(expected: 1, actual: __resultB);
				Assert.AreEqual(expected: 3, actual: __resultC);
				Assert.AreEqual(expected: -1, actual: __resultD);
			}
			
			
			[UnityTest]
			public IEnumerator Rounding_Float_Round_Mode_Down()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			[UnityTest]
			public IEnumerator Rounding_Float_RoundToInt_Mode_Down()
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

				yield return null;

				Assert.AreEqual(expected: 0, actual: __resultA);
				Assert.AreEqual(expected: 0, actual: __resultB);
				Assert.AreEqual(expected: 2, actual: __resultC);
				Assert.AreEqual(expected: -2, actual: __resultD);
			}
			
			#endregion
		}
	}
}