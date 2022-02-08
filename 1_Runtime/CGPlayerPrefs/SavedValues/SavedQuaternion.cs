using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
	using static PackageConstants;
	
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
		[MethodImpl(INLINE)]
		public static quaternion Load(this String key, in quaternion defaultValue)
			=> Load(key: key, defaultValue: defaultValue.value);
			
		[MethodImpl(INLINE)]
		public static void Save(this String key, in quaternion value)
			=> Save(key: key, value: value.value);
	}
}