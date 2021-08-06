using System;

using NUnit.Framework;

using Unity.Mathematics;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	using I32 = Int32;

	public sealed class SavedInt3Tests
	{
		[Test]
		public void ReadWrite()
		{
			int3 __value = new int3(x: 69, y: 420, z: 666);
			
			SavedInt3 __savedInt3 = new SavedInt3(key: "TestSavedInt3", defaultValue: int3.zero);
			
			__savedInt3.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __savedInt3.Read());
		}
	}
}