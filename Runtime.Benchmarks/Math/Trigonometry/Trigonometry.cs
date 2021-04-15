using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Math
	{
		public sealed partial class TrigonometryBenchmarks
		{
			[Test, Performance]
			public void Sqrt()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Sqrt();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Sqrt_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.SqrtFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}


			[Test, Performance]
			public void Power()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Pow(4);
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Squared()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Squared();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Cubed()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Cubed();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}



			[Test, Performance]
			public void Sin()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Sin();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Sin_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.SinFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Asin()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Asin();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Asin_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.AsinFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}


			[Test, Performance]
			public void Cos()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Cos();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Cos_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.CosFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Acos()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Acos();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Acos_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.AcosFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}


			[Test, Performance]
			public void Tan()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Tan();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Tan_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.TanFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Atan()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.Atan();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Atan_Fast()
			{
				Measure.Method(() =>
					{
						float __result = 0.54f.AtanFast();
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			#region Distance

			private readonly Vector3 _posA = Vector3.zero, _posB = new Vector3(15, 2, -34);

			[Test, Performance]
			public void SqrDistance()
			{
				Measure.Method(() =>
					{
						float __distance = _posA.SqrDistance(_posB);
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Distance()
			{
				Measure.Method(() =>
					{
						float __distance = _posA.Distance(to: _posB);
					})
					.WarmupCount(5)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			#endregion

		}
	}
}