using System;

using NUnit.Framework;

using Unity.Mathematics;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	using I32 = Int32;

	public sealed class SavedInt2Tests
	{
		[Test]
		public void ReadWrite()
		{
			int2 __value = new int2(x: 69, y: 420);
			
			SavedInt2 __savedInt2 = new SavedInt2(key: "TestSavedInt2", defaultValue: int2.zero);
			
			__savedInt2.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __savedInt2.Read());
		}
	}
}