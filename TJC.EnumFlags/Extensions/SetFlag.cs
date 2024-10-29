namespace TJC.EnumFlags.Extensions;

/// <summary>
/// Conversion to UInt64 is used to support enums with any underlying type.
/// <para>Supports enums with the following underlying types:</para>
/// <para>byte, sbyte, short, ushort, int, uint, long, or ulong</para>
/// </summary>
public static partial class EnumFlags
{
    /// <summary>
    /// Sets a flag in a flags enum.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="flags"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static void SetFlag<T>(this ref T flags, T flag) where T : struct, Enum
    {
        if (!typeof(T).IsEnum)
            throw new ArgumentException($"{nameof(T)} [{typeof(T).Name}] must be an enum.");

        var flagsValue = Convert.ToUInt64(flags);
        // Get flag to set
        var flagValue = Convert.ToUInt64(flag);

        flagsValue |= flagValue;

        flags = (T)Enum.ToObject(typeof(T), flagsValue);
    }
}