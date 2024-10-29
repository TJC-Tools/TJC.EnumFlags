namespace TJC.EnumFlags.Extensions;

public static partial class EnumFlags
{
    /// <summary>
    /// Clears a flag in a flags enum.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="flags"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static void ClearFlag<T>(this ref T flags, T flag) where T : struct, Enum
    {
        if (!typeof(T).IsEnum)
            throw new ArgumentException($"{nameof(T)} [{typeof(T).Name}] must be an enum.");

        var flagsValue = Convert.ToUInt64(flags);
        // Get flag to clear
        var flagValue = Convert.ToUInt64(flag);

        flagsValue &= ~flagValue;

        flags = (T)Enum.ToObject(typeof(T), flagsValue);
    }
}