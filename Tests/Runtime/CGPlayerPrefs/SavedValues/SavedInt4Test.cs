using System;

using NUnit.Framework;

using Unity.Mathematics;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	using I32 = Int32;

	public sealed class SavedInt4Tests
	{
		[Test]
		public void ReadWrite()
		{
			int4 __value = new int4(x: 69, y: 420, z: 666, w: 1337);
			
			SavedInt4 __savedInt4 = new SavedInt4(key: "TestSavedInt4", defaultValue: int4.zero);
			
			__savedInt4.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __savedInt4.Read());
		}
	}
}