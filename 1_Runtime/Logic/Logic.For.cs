using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

namespace CGTK.Utilities
{
	namespace Extensions
	{
		/// <summary>
		/// These are extensions useful for chaining logic in a single line.
		/// Don't use them if performance is important, these are just to make certain parts of your code more readable.
		/// </summary>
		public static partial class Logic
		{
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void For<T>(this IEnumerable<T> list, in Action action)
			{
				foreach (T __ in list)
				{
					action();
				}
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void ReverseFor<T>(this IList<T> list, in Action action)
			{
				for (Int32 __index = list.Count - 1; __index >= 0; __index--)
				{
					action();
				}
			}

			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void For1<T>(this IEnumerable<T> list, in Action action)
			{
				using IEnumerator<T> __enumerator = list.GetEnumerator();

				while (__enumerator.MoveNext())
				{
					action();
				}
			}


			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void For<T>(this IEnumerable<T> list, in Action<T> action)
			{
				foreach (T __element in list)
				{
					action(__element);
				}
			}
			
			[PublicAPI]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void ReverseFor<T>(this IList<T> list, in Action<T> action)
			{
				for (Int32 __index = list.Count - 1; __index >= 0; __index--)
				{
					action(list[index: __index]);
				}
			}
		}
	}
}