using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
	using static PackageConstants;
	
	using I32 = Int32;
    
	[PublicAPI]
	public sealed class SavedInt : SavedValue<I32>
	{
		public SavedInt(in String key, in I32 defaultValue = default) : base(key, defaultValue)
		{ }

		public override I32 Read()
			=> CGPlayerPrefs.Load(key: Key, defaultValue: DefaultValue);

		public override void Write(in I32 value)
			=> CGPlayerPrefs.Save(key: Key, value);
	}
    
	public static partial class CGPlayerPrefs
	{
		[MethodImpl(INLINE)]
		public static I32 Load(in String key, in I32 defaultValue)
			=> UnityEngine.PlayerPrefs.GetInt(key: key, defaultValue: defaultValue);
        
		[MethodImpl(INLINE)]
		public static void Save(in String key, in I32 value)
			=> UnityEngine.PlayerPrefs.SetInt(key: key, value: value);
	}
}