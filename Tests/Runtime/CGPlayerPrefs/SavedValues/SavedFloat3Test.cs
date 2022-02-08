using NUnit.Framework;
using Unity.Mathematics;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
	public sealed class SavedFloat3Tests
	{
		[Test]
		public void ReadWrite()
		{
			float3 __value = new float3(69.5f, 420.5f, 1337.5f);
			
			SavedFloat3 __saved = new SavedFloat3(key: "TestSavedFloat3", defaultValue: float3.zero);
			
			__saved.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __saved.Read());
		}
	}
}