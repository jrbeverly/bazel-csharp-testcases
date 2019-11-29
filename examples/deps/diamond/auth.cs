using System;

namespace Auth
{
    public static class Permissions
    {
        private const string ADMIN = "jrbeverly";

        public static bool IsAuthorized(string username)
        {
            return username.Equals(ADMIN);
        }

        public static bool IsAuthorized(string username, string environment)
        {
            var rand = new Random();
            return rand.Next(101) > 50;
        }
    }
}