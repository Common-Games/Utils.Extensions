using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;
using CGTK.Utils.Extensions.Math;
using CGTK.Utils.Extensions.Collections;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
	using static PackageConstants;
	
	[PublicAPI]
	public sealed class SavedInt2 : SavedValue<int2>
	{
		public SavedInt2(in String key, in int2 defaultValue = default) : base(key, defaultValue)
		{ }

		public override int2 Read()
			=> Key.Load(defaultValue: DefaultValue);

		public override void Write(in int2 value)
			=> Key.Save(value);
	}

	public static partial class CGPlayerPrefs
	{
		[MethodImpl(INLINE)]
		public static int2 Load(this String key, in int2 defaultValue)
			=> Load(key, arrayLength: 2, defaultValue: defaultValue.ToArray()).ToInt2();

		[MethodImpl(INLINE)]
		public static void Save(this String key, in int2 value)
			=> Save(key: key, value: value.ToArray());
	}
}