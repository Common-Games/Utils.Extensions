using System;
using System.Runtime.CompilerServices;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace CGTK.Utils.Extensions
{
    public static class InputExtensions
    {
		#if ENABLE_INPUT_SYSTEM
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Boolean IsHeld(this InputAction inputAction) => (inputAction.ReadValue<Single>() >= 1.0f);
		#endif
	}
}
