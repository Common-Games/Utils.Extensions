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
	public sealed class SavedInt4 : SavedValue<int4>
	{
		public SavedInt4(in String key, in int4 defaultValue = default) : base(key, defaultValue)
		{ }

		public override int4 Read()
			=> Key.Load(defaultValue: DefaultValue);

		public override void Write(in int4 value)
			=> Key.Save(value);
	}
	
	public static partial class CGPlayerPrefs
	{
		[MethodImpl(INLINE)]
		public static int4 Load(this String key, in int4 defaultValue)
			=> Load(key, arrayLength: 4, defaultValue: defaultValue.ToArray()).ToInt4();

		[MethodImpl(INLINE)]
		public static void Save(this String key, in int4 value)
			=> Save(key: key, value: value.ToArray());
	}
}