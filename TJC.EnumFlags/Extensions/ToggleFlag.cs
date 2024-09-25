namespace TJC.EnumFlags.Extensions;

public static partial class EnumFlags
{
    /// <summary>
    /// Toggles a flag in a flags enum.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="flags"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static void ToggleFlag<T>(this ref T flags, T flag) where T : struct, Enum
    {
        if (!typeof(T).IsEnum)
            throw new ArgumentException($"{nameof(T)} [{typeof(T).Name}] must be an enum.");

        var flagsValue = Convert.ToUInt64(flags);
        var flagValue = Convert.ToUInt64(flag);

        flagsValue ^= flagValue;

        flags = (T)Enum.ToObject(typeof(T), flagsValue);
    }
}