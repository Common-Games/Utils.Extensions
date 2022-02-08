using System;

using NUnit.Framework;
using Unity.Mathematics;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
	public sealed class SavedFloat2Tests
	{
		[Test]
		public void ReadWrite()
		{
			float2 __value = new float2(69.5f, 420.5f);
			
			SavedFloat2 __saved = new SavedFloat2(key: "TestSavedFloat2", defaultValue: float2.zero);
			
			__saved.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __saved.Read());
		}
	}
}