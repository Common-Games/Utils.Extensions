using NUnit.Framework;
using Unity.Mathematics;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	public sealed class SavedQuaternionTests
	{
		[Test]
		public void ReadWrite()
		{
			quaternion __value = new quaternion(69.5f, 420.5f, 1337.5f, 666.6f);
			
			SavedQuaternion __saved = new SavedQuaternion(key: "TestSavedQuaternion", defaultValue: quaternion.identity);
			
			__saved.Write(__value);

			Assert.AreEqual(expected: __value,  actual: __saved.Read());
		}
	}
}