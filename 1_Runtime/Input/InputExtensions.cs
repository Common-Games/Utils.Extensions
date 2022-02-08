using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
	[PublicAPI]
    public static class InputExtensions
    {
		#if ENABLE_INPUT_SYSTEM
        [MethodImpl(INLINE)]
        public static Boolean IsHeld(this InputAction inputAction) => (inputAction.ReadValue<Single>() >= 1.0f);
		#endif
	}
}
