using System;

using NUnit.Framework;

namespace CGTK.Utilities.Extensions
{
	using F32 = Single;

	using I32 = Int32;
	using I64 = Int64;
    
	using U8  = Byte;
	using U16 = UInt16;
	using U32 = UInt32;
	
	namespace CGPlayerPrefs
	{
		public sealed class CGPlayerPrefsTests
		{
			[Test]
			public void LoadStringArray()
			{
				String[] __array =
				{
					"Rughaar",
					"Neushaar",
					"Oorhaar",
					"Balhaar",
				};
				
				"TestStrings".Save(__array);

				String[] __loaded = "TestStrings".Load(arrayLength: 4, defaultValue: new String[]{});
				
				Assert.AreEqual(expected: __array,  actual: __loaded);
			}
			
			[Test]
			public void LoadIntArray()
			{
				I32[] __array =
				{
					1,
					2,
					3,
					4,
				};
				
				"TestInts".Save(__array);

				I32[] __loaded = "TestInts".Load(arrayLength: 4, defaultValue: new I32[]{});
				
				Assert.AreEqual(expected: __array,  actual: __loaded);
			}
			
			[Test]
			public void LoadFloatArray()
			{
				F32[] __array =
				{
					1.5f,
					2.5f,
					3.5f,
					4.5f,
				};
				
				"TestFloats".Save(__array);

				F32[] __loaded = "TestFloats".Load(arrayLength: 4, defaultValue: new F32[]{});
				
				Assert.AreEqual(expected: __array,  actual: __loaded);
			}
		}
	}
}