using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public sealed class TrigTests
		{
			private const int _MEASURE_COUNT = 20, _ITERATIONS = 10_000;
			
			/*
			[Test, Performance]
			public void TestNormalSqrt()
			{
				Measure.Method(() =>
					{
						//for (int __index = 0; __index < _ITERATIONS; __index++)
						float __result = Mathf.Sqrt(0.54f);
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(_ITERATIONS)
					.MeasurementCount(_MEASURE_COUNT)
					.Run();
			}
			*/

			[Test, Performance]
			public void TestSqrt()
			{
				Measure.Method(() =>
					{
						//for (int __index = 0; __index < _ITERATIONS; __index++)
						float __result = 0.54f.Sqrt();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(_ITERATIONS)
					.MeasurementCount(_MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void TestSqrtFast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.SqrtFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(_ITERATIONS)
					.MeasurementCount(_MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void TestCos()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Cos();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(_ITERATIONS)
					.MeasurementCount(_MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void TestCosFast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.CosFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(_ITERATIONS)
					.MeasurementCount(_MEASURE_COUNT)
					.Run();
			}
		}
	}
}