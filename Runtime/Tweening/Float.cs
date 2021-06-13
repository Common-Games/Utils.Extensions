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
            public static IEnumerator To(this float from, float to, float duration, TweenMethod tweenMethod,
                UpdateType updateType = UpdateType.Update, Action onStart = null, Action onFinish = null)
            {
                YieldInstruction __waitInstruction = updateType == UpdateType.FixedUpdate ? WaitForFixedUpdate : null;

                for (float __time = Time.deltaTime;
                    __time < duration;
                    __time += Time.deltaTime) //TODO: check if 'time = delta' is correct?
                {
                    float __percentage = (__time / duration);
                    tweenMethod(from.Lerp(to, t: __percentage));

                    yield return __waitInstruction;
                }
            }
        }
    }
}
