namespace TJC.EnumFlags.Extensions;

public static partial class EnumFlags
{
    /// <summary>
    /// Gets all the flags in an enum.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="flags"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static IEnumerable<T> GetFlags<T>(this T flags) where T : struct, Enum
    {
        if (!typeof(T).IsEnum)
            throw new ArgumentException($"{nameof(T)} [{typeof(T).Name}] must be an enum.");

        var flagsValue = Convert.ToUInt64(flags);
        foreach (T flag in Enum.GetValues(typeof(T)))
        {
            var flagValue = Convert.ToUInt64(flag);
            if (flagValue != 0 && (flagsValue & flagValue) == flagValue)
                yield return flag;
        }
    }
}