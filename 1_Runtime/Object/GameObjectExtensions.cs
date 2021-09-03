using System.Collections.Generic;
using System.Runtime.CompilerServices;

using UnityEngine;
using static UnityEngine.Object;

using JetBrains.Annotations;

namespace CGTK.Utilities
{
    namespace Extensions
    {
        public static partial class GameObjectExtensions
        {
            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void CGDestroyAll<T>(this IEnumerable<T> list)
                where T : Component
            {
                foreach (T __component in list)
                {
                    CGDestroyGameObject(__component);
                }
            }

            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void CGDestroyAll(this IEnumerable<GameObject> list)
            {
                foreach (GameObject __gameObject in list)
                {
                    CGDestroyGameObject(__gameObject);
                }
            }

            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void CGDestroyGameObject(this GameObject obj)
            {
                #if UNITY_EDITOR
                if (Application.isPlaying)
                {
                    Destroy(obj);
                }
                else
                {
                    DestroyImmediate(obj);
                }
                #else
                Destroy(obj);
                #endif
            }

            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void CGDestroyGameObject<T>(this T component)
                where T : Component
            {
                #if UNITY_EDITOR
                if (Application.isPlaying)
                {
                    Destroy(component.gameObject);
                }
                else
                {
                    DestroyImmediate(component.gameObject);
                }
                #else
                Destroy(component.gameObject);
                #endif
            }
            
            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void CGDestroyComponent<T>(this T component)
                where T : Object
            {
                #if UNITY_EDITOR
                if (Application.isPlaying)
                {
                    Destroy(component);
                }
                else
                {
                    DestroyImmediate(component);
                }
                #else
                Destroy(component);
                #endif
            }
        }
    }
}
