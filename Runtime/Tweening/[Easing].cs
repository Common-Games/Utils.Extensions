using System.Runtime.CompilerServices;

using JetBrains.Annotations;

namespace CGTK.Utilities.Extensions
{
	using Math;

	namespace Tweening
	{
		public static partial class Tweening
		{
			public delegate float TweenMethod(float t);

			public enum TweenType
			{
				Linear,
				QuadIn,
				QuadOut,
				QuadInOut,
				CubicIn,
				CubicOut,
				CubicInOut,
				QuartIn,
				QuartOut,
				QuartInOut,
				QuintIn,
				QuintOut,
				QuintInOut,
				BounceIn,
				BounceOut,
				BounceInOut,
				ElasticIn,
				ElasticOut,
				ElasticInOut,
				CircularIn,
				CircularOut,
				CircularInOut,
				SinusIn,
				SinusOut,
				SinusInOut,
				ExponentialIn,
				ExponentialOut,
				ExponentialInOut
			}

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static TweenMethod GetTweenMethod(in TweenType tweenType)
			{
				return tweenType switch
				{
					TweenType.Linear => Linear,
					TweenType.QuadIn => QuadIn,
					TweenType.QuadOut => QuadOut,
					TweenType.QuadInOut => QuadInOut,
					TweenType.CubicIn => CubicIn,
					TweenType.CubicOut => CubicOut,
					TweenType.CubicInOut => CubicInOut,
					TweenType.QuartIn => QuartIn,
					TweenType.QuartOut => QuartOut,
					TweenType.QuartInOut => QuartInOut,
					TweenType.QuintIn => QuintIn,
					TweenType.QuintOut => QuintOut,
					TweenType.QuintInOut => QuintInOut,
					TweenType.BounceIn => BounceIn,
					TweenType.BounceOut => BounceOut,
					TweenType.BounceInOut => BounceInOut,
					TweenType.ElasticIn => ElasticIn,
					TweenType.ElasticOut => ElasticOut,
					TweenType.ElasticInOut => ElasticInOut,
					TweenType.CircularIn => CircularIn,
					TweenType.CircularOut => CircularOut,
					TweenType.CircularInOut => CircularInOut,
					TweenType.SinusIn => SinusIn,
					TweenType.SinusOut => SinusOut,
					TweenType.SinusInOut => SinusInOut,
					TweenType.ExponentialIn => ExponentialIn,
					TweenType.ExponentialOut => ExponentialOut,
					TweenType.ExponentialInOut => ExponentialInOut,
					_ => Linear
				};
			}

			#region Easing Methods

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Linear(float t)
				=> t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuadIn(float t)
				=> t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuadOut(float t)
				=> t * (2f - t);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuadInOut(float t)
				=> t < 0.5f ? 2f * t * t : -1f + (4f - 2f * t) * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CubicIn(float t)
				=> t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CubicOut(float t)
				=> (t - 1f) * t * t + 1f;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CubicInOut(float t)
				=> t < 0.5f ? 4f * t * t * t : (t - 1f) * (2f * t - 2f) * (2 * t - 2) + 1f;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuartIn(float t)
				=> t * t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuartOut(float t)
				=> 1f - (t - 1f) * t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuartInOut(float t)
				=> t < 0.5f ? 8f * t * t * t * t : 1f - 8f * (t - 1f) * t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuintIn(float t)
				=> t * t * t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuintOut(float t)
				=> 1f + (t - 1f) * t * t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuintInOut(float t)
				=> t < 0.5f ? 16f * t * t * t * t * t : 1f + 16f * (t - 1f) * t * t * t * t;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float BounceIn(float t)
				=> 1f - BounceOut(1f - t);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float BounceOut(float t)
				=> t < 0.363636374f ? 7.5625f * t * t :
					t < 0.727272749f ? 7.5625f * (t -= 0.545454562f) * t + 0.75f :
					t < 0.909090936f ? 7.5625f * (t -= 0.8181818f) * t + 0.9375f :
					7.5625f * (t -= 21f / 22f) * t + 63f / 64f;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float BounceInOut(float t)
				=> t < 0.5f ? BounceIn(t * 2f) * 0.5f : BounceOut(t * 2f - 1f) * 0.5f + 0.5f;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ElasticIn(float t)
				=> -(2f.Pow(10f * (t -= 1)) * ((t - (0.3f / 4f)) * (2 * Constants.PI) / 0.3f).Sin());

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ElasticOut(float t)
				=> t.Approx(1f) ? 1f : 1f - ElasticIn(1f - t);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ElasticInOut(float t)
				=> (t *= 2f).Approx(2f) ? 1f : (t < 1f)
						? (2f.Pow(10f * (t -= 1)) * ((t - 0.1125f) * (2f * Constants.PI) / 0.45f).Sin() * -0.5f)
						: (2f.Pow(-10f * (t -= 1f)) * ((t - 0.1125f) * (2f * Constants.PI) / 0.45f).Sin() * 0.5f + 1f);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CircularIn(float t)
				=> -((1 - t * t).Sqrt() - 1);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CircularOut(float t)
				=> (1f - (t -= 1f) * t).Sqrt();

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CircularInOut(float t)
				=> (t *= 2f) < 1f ? -1f / 2f * ((1f - t * t).Sqrt() - 1f) : 0.5f * ((1 - (t -= 2) * t).Sqrt() + 1);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SinusIn(float t)
				=> -(t * (Constants.PI_HALF)).Cos() + 1f;

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SinusOut(float t)
				=> (t * (Constants.PI_HALF)).Sin();

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SinusInOut(float t)
				=> -0.5f * ((Constants.PI * t).Cos() - 1f);

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ExponentialIn(float t)
				=> 2f.Pow(10f * (t - 1f));

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ExponentialOut(float t)
				=> (t * (Constants.PI * 0.5f)).Sin();

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float ExponentialInOut(float t)
				=> -0.5f * ((Constants.PI * t).Cos() - 1f);


			#endregion
		}
	}
}