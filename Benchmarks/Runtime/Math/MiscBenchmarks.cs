using System;
using CGTK.Utils.Extensions.Benchmarks;
using NUnit.Framework;

using Unity.PerformanceTesting;

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
		public sealed partial class MiscBenchmarks
		{
			#region Sign

			[Test, Performance]
			public void Sign()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.Sign();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void SignA()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.SignA();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void SignB()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.SignB();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void SignC()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.SignC();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void SignD()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.SignD();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void SignE()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.SignE();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void SignF()
			{
				Measure.Method(() =>
					{
						F32 __result = 0.54f.SignF();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			#endregion

			#region Min

			[Test, Performance]
			public void Min_Int()
			{
				Measure.Method(() =>
					{
						I32 __result = 2.Min(11);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Min_IntTuple()
			{
				Measure.Method(() =>
					{
						I32 __result = (2, 11).Min();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void Min_Float()
			{
				Measure.Method(() =>
					{
						F32 __result = 2f.Min(11f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Min_FloatTuple()
			{
				Measure.Method(() =>
					{
						F32 __result = (2f, 11f).Min();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}


			#endregion

			#region Max

			[Test, Performance]
			public void Max_Int()
			{
				Measure.Method(() =>
					{
						I32 __result = 2.Max(11);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Max_IntTuple()
			{
				Measure.Method(() =>
					{
						I32 __result = (2, 11).Max();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			
			[Test, Performance]
			public void Max_Float()
			{
				Measure.Method(() =>
					{
						F32 __result = 2f.Max(11f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			[Test, Performance]
			public void Max_FloatTuple()
			{
				Measure.Method(() =>
					{
						F32 __result = (2f, 11f).Max();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			#endregion

			/*
			[Test, Performance]
			public void MinB()
			{
				Measure.Method(() =>
					{
						int __result = 2.MinB(11);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void MinC()
			{
				Measure.Method(() =>
					{
						int __result = 2.MinC(11);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void MinD()
			{
				Measure.Method(() =>
					{
						int __result = (2, 11).MinD();
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			*/

			#region Clamp

			[Test, Performance]
			public void Clamp()
			{
				Measure.Method(() =>
					{
						F32 __result = 25f.Clamp(-10f, 20f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void Clamp1()
			{
				Measure.Method(() =>
					{
						F32 __result = 25f.Clamp1(-10f, 20f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void ClampA()
			{
				Measure.Method(() =>
					{
						F32 __result = 25f.ClampA(-10f, 20f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void ClampB()
			{
				Measure.Method(() =>
					{
						F32 __result = 25f.ClampB(-10f, 20f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}
			
			[Test, Performance]
			public void ClampC()
			{
				Measure.Method(() =>
					{
						F32 __result = 25f.ClampC(-10f, 20f);
					})
					.WarmupCount(BenchmarkSettings.WARMUP_COUNT)
					.IterationsPerMeasurement(BenchmarkSettings.ITERATIONS)
					.MeasurementCount(BenchmarkSettings.MEASURE_COUNT)
					.Run();
			}

			#endregion

		}
	}
}