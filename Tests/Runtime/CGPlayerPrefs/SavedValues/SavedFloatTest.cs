using System;

using NUnit.Framework;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	using F32 = Single;

	public sealed class SavedFloatTests
	{
		[Test]
		public void ReadWrite()
		{
			const F32 __VALUE = 69.5f;
			
			SavedFloat __saved = new SavedFloat(key: "TestSavedFloat", defaultValue: 100);
			
			__saved.Write(__VALUE);

			Assert.AreEqual(expected: __VALUE,  actual: __saved.Read());
		}
	}
}