using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using Unity.Mathematics;

using CGTK.Utilities.Extensions.Collection;
using CGTK.Utilities.Extensions.Math;

namespace CGTK.Utilities.Extensions.CGPlayerPrefs
{
    [PublicAPI]
    public sealed class SavedFloat2 : SavedValue<float2>
    {
        public SavedFloat2(in String key, in float2 defaultValue = default) : base(key, defaultValue)
        { }

        public override float2 Read()
            => CGPlayerPrefs.Load(key: Key, defaultValue: DefaultValue);

        public override void Write(in float2 value)
            => CGPlayerPrefs.Save(key: Key, value);
    }

    public static partial class CGPlayerPrefs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 Load(in String key, in float2 defaultValue)
            => Load(key, arrayLength: 2, defaultValue: defaultValue.ToArray()).ToFloat2();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Save(in String key, in float2 value)
            => Save(key: key, value: value.ToArray());
    }
}