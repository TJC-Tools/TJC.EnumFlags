namespace TJC.EnumFlags.Extensions;

public static partial class EnumFlags
{
    /// <summary>
    /// Sets one or more flags on an enum.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="flags"></param>
    /// <param name="flagsToSet"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static void SetFlags<T>(this ref T flags, IEnumerable<T> flagsToSet)
        where T : struct, Enum
    {
        if (!typeof(T).IsEnum)
            throw new ArgumentException($"{nameof(T)} [{typeof(T).Name}] must be an enum.");

        var flagsValue = Convert.ToUInt64(flags);

        foreach (var flag in flagsToSet)
            flagsValue |= Convert.ToUInt64(flag);

        flags = (T)Enum.ToObject(typeof(T), flagsValue);
    }
}
