using System;
using System.Collections;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	using Math;

	namespace Tweening
	{
		public static partial class Tweening
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			//public static float To(this float from, in float to, in float duration, in EaseMethod easeMethod, in UpdateType updateType = UpdateType.Update, in Action onStart = null, in Action onFinish = null)
			public static IEnumerator To(this Vector3 from, Vector3 to, float duration, Action<Vector3> callback,
				UpdateType updateType = UpdateType.Update, Action onStart = null, Action onFinish = null)
			{
				YieldInstruction __waitInstruction = updateType == UpdateType.FixedUpdate ? WaitForFixedUpdate : null;

				for (float __time = 0; __time <= duration; __time += Time.deltaTime) //TODO: check if 'time = delta' is correct?
				{
					float __percentage = (__time / duration);
					callback(from.Lerp(to, t: __percentage));

					yield return __waitInstruction;
				}
			}

			/// <summary>
			/// Interpolates from <paramref name="from"> to <paramref name="to"> for the given <paramref name="duration"> in seconds.
			/// Uses the given <paramref name="curve"> for tweening.
			/// Calls <paramref name="callback"> and passes the interpolated value to it in every step.
			/// <param name="from">The initial value to start from.</param>
			/// <param name="to">The target value to interpolate towards.</param>
			/// <param name="duration">The duration in seconds the interpolation is supposed to last.</param>
			/// <param name="curve">The curve describing the tween. Consider using the available ones from the CorouTween class.</param>
			/// <param name="callback">The callback called each step. The current interpolation result is passed to it.</param>
			/// <param name="updateType">Choose between interpolation in Update or FixedUpdate.</param>
			/// </summary>

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static IEnumerator Interpolate(this Vector3 from, Vector3 to, float duration,
				Action<Vector3> callback, TweenType tweenType,
				UpdateType updateType = UpdateType.Update, Action onStart = null, Action onFinish = null)
			{
				return Interpolate(from, to, duration, 
					callback, tweenMethod: GetTweenMethod(tweenType), 
					updateType, onStart, onFinish);
			}

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static IEnumerator Interpolate(this Vector3 from, Vector3 to, float duration,
				Action<Vector3> callback, TweenMethod tweenMethod,
				UpdateType updateType = UpdateType.Update, Action onStart = null, Action onFinish = null)
			{
				onStart?.Invoke();
				YieldInstruction __waitInstruction = updateType == UpdateType.FixedUpdate ? WaitForFixedUpdate : null;

				for (float __time = 0; __time <= duration; __time += Time.deltaTime)
				{
					float __percentage = (__time / duration);
					callback(from.Lerp(to, t: tweenMethod(__percentage)));
					
					yield return __waitInstruction;
				}

				onFinish?.Invoke();
				callback(from.Lerp(to, t: tweenMethod(1)));
			}

		}
	}
}