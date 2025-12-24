
using System;

namespace ConcurrentDictionary.Tests.System;

internal static class PlatformHelper
{
    public static int ProcessorCount
    {
        get { return Environment.ProcessorCount; }
    }
}