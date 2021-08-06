using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;

using CGTK.Utilities.Extensions.Collection;
using CGTK.Utilities.Extensions.Math;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 Load(this String key, in int3 defaultValue)
			=> Load(key, arrayLength: 3, defaultValue: defaultValue.ToArray()).ToInt3();

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Save(this String key, in int3 value)
			=> Save(key: key, value: value.ToArray());
	}
}