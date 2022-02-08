using System;
using System.Runtime.CompilerServices;

using UnityEngine;

using JetBrains.Annotations;

namespace CGTK.Utils.Extensions
{
    using static PackageConstants;
    
    namespace Math
    {
        public static partial class VectorExtensions
        {
            [MethodImpl(INLINE)]
            public static Boolean Approx(in this Vector2 self, in Vector2 compareTo) 
                => (self.x.Approx(compareTo.x) && 
                    self.y.Approx(compareTo.y));

        }
    }
}
