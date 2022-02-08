using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

namespace CGTK.Utils.Extensions.CGPlayerPrefs
{
    using static PackageConstants;
    
    using F32 = Single;
    
    [PublicAPI]
    public sealed class SavedFloat : SavedValue<F32>
    {
        public SavedFloat(in String key, in F32 defaultValue = default) : base(key, defaultValue)
        { }

        public override F32 Read()
            => CGPlayerPrefs.Load(key: Key, defaultValue: DefaultValue);

        public override void Write(in F32 value)
            => CGPlayerPrefs.Save(key: Key, value);
    }
    
    public static partial class CGPlayerPrefs
    {
        [MethodImpl(INLINE)]
        public static F32 Load(in String key, in F32 defaultValue)
            => UnityEngine.PlayerPrefs.GetFloat(key: key, defaultValue: defaultValue);
        
        [MethodImpl(INLINE)]
        public static void Save(in String key, in F32 value)
            => UnityEngine.PlayerPrefs.SetFloat(key: key, value: value);
    }
}
