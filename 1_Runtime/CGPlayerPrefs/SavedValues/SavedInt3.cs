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
	public sealed class SavedInt3 : SavedValue<int3>
	{
		public SavedInt3(in String key, in int3 defaultValue = default) : base(key, defaultValue)
		{ }

		public override int3 Read()
			=> Key.Load(defaultValue: DefaultValue);

		public override void Write(in int3 value)
			=> Key.Save(value);
	}
	
	public static partial class CGPlayerPrefs
	{
		[MethodImpl(INLINE)]
		public static int3 Load(this String key, in int3 defaultValue)
			=> Load(key, arrayLength: 3, defaultValue: defaultValue.ToArray()).ToInt3();

		[MethodImpl(INLINE)]
		public static void Save(this String key, in int3 value)
			=> Save(key: key, value: value.ToArray());
	}
}