using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CGTK.Utils.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>Very slow, ONLY use it for editor scripts.</summary>
        public static void Add<T>(this T[] array, params T[] elements)
        {
            array = array.Concat(elements).ToArray();
        }
    }
}
