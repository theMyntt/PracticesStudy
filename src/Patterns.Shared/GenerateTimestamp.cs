namespace Patterns.Shared;

public class GenerateTimestamp
{
    public static long Perform()
    {
        return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
    }
}