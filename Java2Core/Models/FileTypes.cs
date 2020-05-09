using System;

namespace Java2Core.Models
{
    [Flags]
    public enum FileTypes
    {
        Unknown = 1 << 0,
        Source = 1 << 1,
        Document = 1 << 2,
        Configuration = 1 << 3,
        Script = 1 << 4,
    }
}
