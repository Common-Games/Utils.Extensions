using NUnit.Framework;

using UnityEngine;

namespace CGTK.Utilities.Extensions
{
	namespace Type
	{
		public sealed class TypeTests
		{
			private sealed class MockMonoBehaviour : MonoBehaviour { }
			private sealed class MockScriptableObject : MonoBehaviour { }
			
			private sealed class MockClass { }
			private struct MockStruct { }

			[Test]
			public void HasUnityEventFunctions()
			{
				Assert.AreEqual(expected: true,  actual: typeof(MockMonoBehaviour).HasUnityEventFunctions());
				Assert.AreEqual(expected: true,  actual: typeof(MockScriptableObject).HasUnityEventFunctions());
				Assert.AreEqual(expected: false, actual: typeof(MockClass).HasUnityEventFunctions());
				Assert.AreEqual(expected: false, actual: typeof(MockStruct).HasUnityEventFunctions());
			}
		}
	}
}