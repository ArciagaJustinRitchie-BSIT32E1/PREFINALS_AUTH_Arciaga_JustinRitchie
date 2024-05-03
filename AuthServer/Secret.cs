using System;

namespace AuthServer
{
    public static class Secret
    {
        public static string JwtSigningKey { get; } = Guid.NewGuid().ToString();
    }
}
