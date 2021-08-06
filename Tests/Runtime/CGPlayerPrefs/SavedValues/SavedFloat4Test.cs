using NUnit.Framework;
using Unity.Mathematics;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	public sealed class SavedFloat4Tests
	{
		[Test]
		public void ReadWrite()
		{
			float4 __value = new float4(69.5f, 420.5f, 1337.5f, 666.6f);
			
			SavedFloat4 __saved = new SavedFloat4(key: "TestSavedFloat4", defaultValue: float4.zero);
			
			__saved.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __saved.Read());
		}
	}
}