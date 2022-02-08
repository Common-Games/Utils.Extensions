using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;
using CGTK.Utilities.Extensions.Math;
using CGTK.Utils.Extensions.Collections;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
    [PublicAPI]
    public sealed class SavedFloat3 : SavedValue<float3>
    {
        public SavedFloat3(in String key, in float3 defaultValue = default) : base(key, defaultValue)
        { }

        public override float3 Read()
            => Key.Load(defaultValue: DefaultValue);

        public override void Write(in float3 value)
            => Key.Save(value);
    }
    
    public static partial class CGPlayerPrefs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Load(this String key, in float3 defaultValue)
            => Load(key, arrayLength: 3, defaultValue: defaultValue.ToArray()).ToFloat3();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Save(this String key, in float3 value)
            => Save(key: key, value: value.ToArray());
    }
}
