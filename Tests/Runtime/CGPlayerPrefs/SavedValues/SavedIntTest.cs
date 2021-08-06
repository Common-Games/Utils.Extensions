using System;

using NUnit.Framework;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	using I32 = Int32;

	public sealed class SavedIntTests
	{
		[Test]
		public void ReadWrite()
		{
			const I32 __VALUE = 69;
			
			SavedInt __savedInt = new SavedInt(key: "TestSavedInt", defaultValue: 100);
			
			__savedInt.Write(__VALUE);

			Assert.AreEqual(expected: __VALUE,  actual: __savedInt.Read());
		}
	}
}