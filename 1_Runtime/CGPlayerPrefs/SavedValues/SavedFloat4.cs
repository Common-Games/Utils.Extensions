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
    public sealed class SavedFloat4 : SavedValue<float4>
    {
        public SavedFloat4(in String key, in float4 defaultValue = default) : base(key, defaultValue)
        { }

        public override float4 Read()
            => Key.Load(defaultValue: DefaultValue);

        public override void Write(in float4 value)
            => Key.Save(value);
    }
    
    public static partial class CGPlayerPrefs
    {
        [MethodImpl(INLINE)]
        public static float4 Load(this String key, in float4 defaultValue)
            => Load(key, arrayLength: 4, defaultValue: defaultValue.ToArray()).ToFloat4();

        [MethodImpl(INLINE)]
        public static void Save(this String key, in float4 value)
            => Save(key: key, value: value.ToArray());
    }
}
