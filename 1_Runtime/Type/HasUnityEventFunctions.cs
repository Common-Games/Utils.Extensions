using System;
using System.Runtime.CompilerServices;

using UnityEngine;

using JetBrains.Annotations;

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
	[PublicAPI]
    public static class TypeChecks
    {
        [MethodImpl(INLINE)]
        public static Boolean HasUnityEventFunctions(this Type type)
	        => (type == null) || (type.IsSubclassOf(c: typeof(MonoBehaviour)) || type.IsSubclassOf(c: typeof(ScriptableObject)));
	}
}
