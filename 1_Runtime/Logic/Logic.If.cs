using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CGTK.Utils.Extensions
{
	using static PackageConstants;
	
	/// <summary>
	/// These are extensions useful for chaining logic in a single line.
	/// Don't use them if performance is important, these are just to make certain parts of your code more readable.
	/// </summary>
	public static partial class Logic
	{
		[MethodImpl(INLINE)]
		public static void If(this Boolean statement, in Action action)
		{
			if (statement)
			{
				action?.Invoke();
			}
		}
	}
}