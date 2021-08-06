using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	[PublicAPI]
    public static class TypeChecks
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean HasUnityEventFunctions(this Type type)
	        => (type is null) || (type.IsSubclassOf(c: typeof(MonoBehaviour)) || type.IsSubclassOf(c: typeof(ScriptableObject)));
	}
}
