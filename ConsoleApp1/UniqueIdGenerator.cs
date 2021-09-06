using System;

/// <summary>
/// Class helper for Guid Id generation;
/// </summary>

namespace Task001
{
    public static class UniqueIdGenerator
    {
        public static Guid CreateUniqueId ( this string uniqueId )
        {
            return new Guid ( uniqueId );
        }
    }
}
