using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
	[PublicAPI]
	public sealed class SavedQuaternion : SavedValue<quaternion>
	{
		public SavedQuaternion(in String key, in quaternion defaultValue = default) : base(key, defaultValue)
		{ }

		public override quaternion Read()
			=> Key.Load(defaultValue: DefaultValue);

		public override void Write(in quaternion value)
			=> Key.Save(value);
	}
	
	public static partial class CGPlayerPrefs
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion Load(this String key, in quaternion defaultValue)
			=> Load(key: key, defaultValue: defaultValue.value);
			
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Save(this String key, in quaternion value)
			=> Save(key: key, value: value.value);
	}
}