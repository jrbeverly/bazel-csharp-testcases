using System;

using Auth;

namespace Servers
{
    public static class Environments
    {
        private static readonly string[] Machines = { "Ubuntu1604", "Ubuntu1804", "Windows10" };

        public static string[] ListEnvironments(string username)
        {
            if (!Permissions.IsAuthorized(username))
            {
                return new string[0];
            }

            return Machines;
        }
    }
}